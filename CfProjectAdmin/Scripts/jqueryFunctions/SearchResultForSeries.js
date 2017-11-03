$(document).ready(function () {
    var numberPriceValue = null;
    var numberPriceOperator = null;
    if ($("#numberPriceValue").length > 0) {
        numberPriceValue = $("#numberPriceValue").val();
        numberPriceOperator = $("#seriesNumbersOperator").val();
    }
    var url = "/AxiosSeries/searchResultForSeriesF?" + "&matchType=" + $("#matchType").val()
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
});