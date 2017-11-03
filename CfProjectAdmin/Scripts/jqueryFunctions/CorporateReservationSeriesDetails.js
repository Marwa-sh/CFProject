$(window).load(function () {    
    var serieID = $("#serie_id").val();

    $("#reservebtn").attr("disabled", true);
    var requestedNumber = $("#requestedCount").val();

    $(document).on('click', ':checkbox', function () {
        $('input:checkbox').removeAttr('checked');
        var parent = $(this).closest('tr');
        allNextSiblings = parent.nextAll();
        if (allNextSiblings.length >= requestedNumber - 1) {
            this.checked = true;
            var counter = 1;
            $.each(allNextSiblings, function () {
                if (counter == requestedNumber) {
                    return false;
                }
                $(this).find('.checked-number').each(function () {
                    this.checked = true;
                });
                counter++;
            });
        }
        if ($("input:checkbox:checked").length > 0) {
            $("#reservebtn").attr("disabled", false);
        } else {
            $("#reservebtn").attr("disabled", true);
        }
    });

    $(document).on('click', '#reservebtn', function (e) {
        var urlSearch = "/CorporateReservation/ReserveButton";
        var numbersList = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            numbersList.push($(this).attr("value"));
        });
        if (numbersList.length < requestedNumber) {
            $.msgBox({
                title: 'WARNING',
                content: "You have to select at least " + requestedNumber + " number(s).",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $('body').addClass('wait');
            $.ajax({
                url: urlSearch,
                data: { numberIDs: numbersList.toString() },
                type: "GET",
                dataType: "json",
                cache: false,
                async: true,
                success: function (data) {
                    if (data) {
                        location.href = "/CorporateReservation/CorporateReservationRequest?serieID=" + serieID;
                    }
                },
                error: function (data) {
                },
                complete: function () {
                    $('body').removeClass('wait');
                }
            });            
        }
    });
    
})