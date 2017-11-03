$(document).ready(function () {
    $(document).on('click', '#CreateRequest', function () {
        if ($(".checked-number:checked").length > 0) {
            showRequestInformationForm();
        } else {
            showMessage("Please Select Numbers first");
        }
    });
    var numberPriceValue = null;
    var numberPriceOperator = null;
    if ($("#numberPriceValue").length > 0) {
        numberPriceValue = $("#numberPriceValue").val();
        numberPriceOperator = $("#seriesNumbersOperator").val();
    }
    var url = "/AdminSeriesReservation/searchResultForSeriesF?" + "&matchType=" + $("#matchType").val()
                + "&matchText=" + $("#matchText").val() + "&matchAllAny="+$("#matchAllAny").val()
                + "&rangeString=" + $("#rangeString").val() + "&classificationString=" + $("#classificationString").val()
                + "&poolsString=" + $("#poolsString").val() + "&relatedPoolsOperator=" + $("#relatedPoolsOperator").val()
                + "&relatedPoolsValue=" + $("#relatedPoolsValue").val() + "&numberPriceOperator=" + $("#numberPriceOperator").val()
                + "&numberPriceValue=" + numberPriceValue
                + "&seriesNumbersOperator=" + numberPriceOperator
                + "&requestedCount=" + $("#requestedCount").val()

                + "&totalScoreOperator=" + $("#totalScoreOperator").val() +
                  "&totalScoreValue=" + $("#totalScoreValue").val()
                + "&avScoreOperator=" + $("#avScoreOperator").val() +
                  "&avScoreValue=" + $("#avScoreValue").val()
                + "&";
    var moveLeft = 20;
    var moveDown = 10;
    $().loadMore({
        button: $("#load-more"),
        container: $("#series-container"),
        auto: false,
        url: url,
    });


    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#series-container"),
        url: url,
    });


    //related pools
    $('.relatedPools').click(null, function (e) {
        var seriesId = $(this).attr("seriesId");
        $.ajax({
            url: "/AxiosSeries/getRelatedPools",
            type: "GET",
            data: { seriesId: seriesId },
            dataType: "json",
            traditional: true,
            cache: false,
            async: true,
            success: function (data) {
                $('div#relatedPools_popUp').html('');
                $('div#relatedPools_popUp').show()
                                  .css('top', e.pageY + moveDown)
                                  .css('left', e.pageX + moveLeft)
                                  .append('<table>' + data + '</table>')
                                  .appendTo('body');
            },
            error: function (data) {
            }
        });
    });
    $(document).click(null, function () {
        $('div#relatedPools_popUp').html('');
        $('div#relatedPools_popUp').hide();
    });
    $(document).on('contentChanged', function () {
        $('.relatedPools').click(null, function (e) {
            var seriesId = $(this).attr("seriesId");
            $.ajax({
                url: "/AxiosSeries/getRelatedPools",
                type: "GET",
                data: { seriesId: seriesId },
                dataType: "json",
                traditional: true,
                cache: false,
                async: true,
                success: function (data) {
                    $('div#relatedPools_popUp').html('');
                    $('div#relatedPools_popUp').show()
                               .css('top', e.pageY + moveDown)
                               .css('left', e.pageX + moveLeft)
                               .append('<table>' + data + '</table>')
                               .appendTo('body');
                },
                error: function (data) {
                }
            });
        });
        $(document).click(null, function () {
            $('div#relatedPools_popUp').html('');
            $('div#relatedPools_popUp').hide();
        });

    });


    $("#Reserve").attr("disabled", true);
    var requestedNumber = $("#requestedNumberCount").val();
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
            $("#Reserve").attr("disabled", false);
        } else {
            $("#Reserve").attr("disabled", true);
        }
    });
});

function showRequestInformationForm() {
    var button = {
        success: {
            label: "OK",
            className: "btn btn-primary",
            callback: function () {
                $("#form-container").find('.error').remove();
                var requesterGroup = $("#requesterGroupElem").val(); var requester = $("#requesterElem").val();
                var idType = $("#idTypeElem").val(); var customerName = $("#customerNameElem").val();
                var customerId = $("#customerIdElem").val(); var contractNumber = $("#contractNumberElem").val();
                var requestReason = $("#requestReasonElem").val(); var oldNumber = $("#oldNumberElem").val();
                var remark = $("#remarkElem").val();
                if (requesterGroup == "-1") {
                    $("#rg").append("<span class='error'> Data Required</span>");
                    return false;
                }
                else if (requester == "-1") {
                    $("#r").append("<span class='error'> Data Required</span>");
                    return false;
                }
                else if ($(".checked-number:checked").length <= 0) {
                    $.msgBox({
                        title: 'Warning',
                        content: 'You have to choose at least one number',
                        opacity: 0.5,
                        buttons: [{ value: "OK" }],
                        success: function (result) {

                        }
                    })
                    return true;
                }
                else {
                    $('#createRequest').append('<input type="hidden" name = "requesterId" value="' + requester + '" />');
                    $('#createRequest').append('<input type="hidden" name = "requesterGroupId" value="' + requesterGroup + '" />');
                    $('#createRequest').append('<input type="hidden" name = "idType" value="' + idType + '" />');
                    $('#createRequest').append('<input type="hidden" name = "idNumber" value="' + customerId + '" />');
                    $('#createRequest').append('<input type="hidden" name = "customerName" value="' + customerName + '" />');
                    $('#createRequest').append('<input type="hidden" name = "contractNumber" value="' + contractNumber + '" />');
                    $('#createRequest').append('<input type="hidden" name = "requestReason" value="' + requestReason + '" />');
                    $('#createRequest').append('<input type="hidden" name = "oldNumber" value="' + oldNumber + '" />');
                    $('#createRequest').append('<input type="hidden" name = "remark" value="' + remark + '" />');

                    $("#createRequest").submit()
                }
            }
        },
        danger: {
            label: "Cancel",
            className: "btn btn-default",
            callback: function () {
                return true;
            }
        }
    };

    var box = bootbox.dialog({
        size: 'medium',
        title: "Fill Request Information",
        message: '<span id="form-container">'
                    + '<span class="col-xs-3" id="rg">Requester Group :</span> <span class="col-xs-9"><select id="requesterGroupElem" name="requesterGroup" type="select" class = "selectpicker show-tick show-menu-arrow" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "4" data_actions_box = "true" ></select></span><br />'
                    + '<span class="col-xs-3" id="r">Requester :</span> <span class="col-xs-9"><select id="requesterElem" name="requesterElem" type="select" class = "selectpicker show-tick show-menu-arrow" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "4" data_actions_box = "true" ></select></span><br />'
                    + '<span class="col-xs-3">Id Type :</span> <span class="col-xs-9"><select id="idTypeElem" name="idType" type="select" class = "selectpicker show-tick show-menu-arrow" data_live_search_placeholder = "Search" data_width = "100%" data_live_search = "true" data_size = "4" data_actions_box = "true" ></select></span><br />'
                    + '<span class="col-xs-3">Customer Name :</span> <span class="col-xs-9"><input class="form-control" type="text" name="customerName" id="customerNameElem" /></span><br/>'
                    + '<span class="col-xs-3">Customer ID :</span> <span class="col-xs-9"><input class="form-control" type="text" name="customerId" id="customerIdElem" /></span><br/>'
                    + '<span class="col-xs-3">Contract Number :</span> <span class="col-xs-9"><input class="form-control" type="text" name="contractNumber" id="contractNumberElem" /></span><br/>'
                    
                    + '<span class="col-xs-3">Remark :</span> <span class="col-xs-9"><textarea class="form-control" name="remark" id="remarkElem" ></textarea></span><br/>'
                + '</span>'
                ,
        buttons: button
    });
    box.on("shown.bs.modal", function () {
        
        var idType = JSON.parse($("#idType").val());
        var requesterGroups = JSON.parse($("#requesterGroups").val());

        $.each(idType, function (key, value) {
            $("#idTypeElem").append('<option value="' + value.id + '">' + value.text + '</option>');
        });
        $.each(requesterGroups, function (key, value) {
            $("#requesterGroupElem").append('<option value="' + value.id + '">' + value.text + '</option>');
        });

      
        $(".selectpicker").selectpicker();

    
        $(document).on('change', '#requesterGroupElem', function () {
            reqGroupId = $(this).val();
            if (reqGroupId > 0) {
                $('body').addClass('wait');
                $.ajax({
                    type: "POST",
                    url: '/AdminNumberReservation/getRequestersOfGroup?requesterGroupId=' + reqGroupId,
                    dataType: 'json',
                    cache: false,
                    async: true,
                    success: function (data) {
                        $('#requesterElem').html('');
                        requestersIds = data[0];
                        requestersName = data[1];
                        var counter = 0;
                        $.each(requestersIds, function (key, value) {
                            $("#requesterElem").append('<option value="' + value + '">' + requestersName[counter] + '</option>');
                            counter++;
                        });
                        $('.selectpicker').selectpicker('refresh');
                    },
                    error: function (data) {
                        console.log(data);
                    },
                    complete: function () {
                        $('body').removeClass('wait');
                    }
                });
            } else {
                $('#requesterElem').html('');
                $('.selectpicker').selectpicker('refresh');
            }
        });
    });
}