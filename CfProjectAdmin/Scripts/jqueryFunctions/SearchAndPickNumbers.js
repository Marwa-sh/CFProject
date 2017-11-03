$(document).ready(function () {
    var numberPriceValue = null;
    var numberPriceOperator = null;
    if ($("#numberPriceValue").length > 0) {
        numberPriceValue = $("#numberPriceValue").val();
        numberPriceOperator = $("#seriesNumbersOperator").val();
    }
    var url = "/AxiosReservation/searchResultForNumbersF?" + "&matchType=" + $("#matchType").val()
                + "&matchText=" + $("#matchText").val() + "&matchAllAny="+$("#matchAllAny").val()
                + "&rangeString=" + $("#rangeString").val() + "&classificationString=" + $("#classificationString").val()
                + "&poolsString=" + $("#poolsString").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
                + "&relatedPoolsOperator="+$("#relatedPoolsOperator").val() + "&relatedPoolsValue="+$("#relatedPoolsValue").val()
                + "&numberPriceOperator=" + numberPriceOperator + "&numberPriceValue=" + numberPriceValue
                + "&totalScoreOperator=" + $("#totalScoreOperator").val() +
                "&totalScoreValue=" + $("#totalScoreValue").val()
                + "&avScoreOperator=" + $("#avScoreOperator").val() +
                "&avScoreValue=" + $("#avScoreValue").val()
                + "&";
    var moveLeft = 20;
    var moveDown = 10;
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        auto: false,
        url: url,
    });


    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: url,
    });
    $(document).on('change', ':checkbox', function () {
        $("#picked-numbers-container").html("");
        var header = $("#numbers-container tr").first().html();
        $("#picked-numbers-container").append("<tr>" + header + "</tr>");
        $("#picked-numbers-container").find(':checkbox').closest('th').html('');
        $("#picked-numbers-container").find('.fa-sort').closest('a').remove();
        $("#SearchAndPickResult").find(':checked').each(function () {
            var tr = $(this).closest('tr');
            if (tr.attr('id') != 'tableHeader') {
                var row = tr.html();
                var numberId = $(this).closest('tr').attr('number-id');
                $("#picked-numbers-container").append("<tr number-id='" + numberId + "'>" + row + "</tr>");
            }
            
        });
        $("#picked-numbers-container").find(":checkbox").each(function () {
            $(this).replaceWith('<i class="fa fa-minus-circle fa-2x delete-choosed-number" title="Delete" />');
        });
    });
    $(document).on('click', '.delete-choosed-number', function () {
        var numberId = $(this).closest('tr').attr('number-id');
        var removedRow = $("#SearchAndPickResult").find('.number-id[number-id=' + numberId + ']').find('input[type="checkbox"]').attr('checked', false);
        $(this).closest('tr').remove();
    });

    $(document).on('click', '#sort_checkbox', function (e) {
        e.preventDefault();
        var checkedRows = $(".checked-number:checked").closest("tr");
        var cloneCheckedRows = checkedRows.clone();
        var uncheckedRows = $(".checked-number:not(:checked)").closest("tr");
        var cloneUncheckedRows = uncheckedRows.clone();
        var header = $("#numbers-container tr").first().clone();
        $("#numbers-container").html("");
        $("#numbers-container").append(header);
        cloneCheckedRows.each(function () {
            $("#numbers-container").append($(this));
        });
        cloneUncheckedRows.each(function () {
            $("#numbers-container").append($(this));
        });
    });
    $('.relatedPools').click(null, function (e) {
        var numberId = $(this).attr("number_Id");
        $.ajax({
            url: "/Pools/getrelatedNormalPools",
            type: "GET",
            data: { clickedNumber: numberId },
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