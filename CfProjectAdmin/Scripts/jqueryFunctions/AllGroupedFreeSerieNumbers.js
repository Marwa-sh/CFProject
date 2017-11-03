$(window).load(function () {
    var moveLeft = 20;
    var moveDown = 10;
    var url = "matchType=" + $("#matchType").val()
               + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
               + "&rangeString=" + $("#rangeString").val() + "&classificationString=" + $("#classificationString").val()
               + "&statusString=" + $("#statusString").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
               + "&relatedPoolsOperator=" + $("#relatedPoolsOperator").val() + "&relatedPoolsValue=" + $("#relatedPoolsValue").val()
               + "&numberPriceOperator=" + $("#numberPriceOperator").val() + "&numberPriceValue=" + $("#numberPriceValue").val()
               + "&totalScoreOperator=" + $("#totalScoreOperator").val() +
                "&totalScoreValue=" + $("#totalScoreValue").val()
                + "&avScoreOperator=" + $("#avScoreOperator").val() +
                "&avScoreValue=" + $("#avScoreValue").val()
               + "&";
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        auto: false,
        url: "/FreeSeries/getAllGroupedSerieNumbersF?" + url,
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreeSeries/getAllGroupedSerieNumbersF?"+ url,
    });

    $(document).on('click', '.relatedPools', function (e) {
        var serieId = $(this).attr("number_id");
        $.ajax({
            url: "/Pools/getrelatedSeriesPools",
            type: "GET",
            data: { clickedSeries: serieId },
            dataType: "json",
            traditional: true,
            cache: false,
            async: true,
            success: function (data) {
                if (data.length != 0) {
                    $('div#relatedPools_popUp').html('');
                    $('div#relatedPools_popUp').show()
                                      .css('top', e.pageY + moveDown)
                                      .css('left', e.pageX + moveLeft)
                                      .append('<table>' + data + '</table>')
                                      .appendTo('body');
                }
                else {
                    $('div#relatedPools_popUp').html('');
                    $('div#relatedPools_popUp').show()
                          .css('top', e.pageY + moveDown)
                          .css('left', e.pageX + moveLeft)
                          .append('<table>No Pools</table>')
                          .appendTo('body');
                }
            },
            error: function (data) {
            }
        });
    });

    $(document).click(null, function () {
        $('div#relatedPools_popUp').html('');
        $('div#relatedPools_popUp').hide();
    });
    //$(document).on('contentChanged', function () {
    //    $('.relatedPools').click(null, function (e) {
    //        var numberId = $(this).attr("number_id");
    //        $.ajax({
    //            url: "/Pools/getrelatedNormalPools",
    //            type: "GET",
    //            data: { clickedNumber: numberId },
    //            dataType: "json",
    //            traditional: true,
    //            cache: false,
    //            async: true,
    //            success: function (data) {
    //                $('div#relatedPools_popUp').html('');
    //                $('div#relatedPools_popUp').show()
    //                           .css('top', e.pageY + moveDown)
    //                           .css('left', e.pageX + moveLeft)
    //                           .append('<table>' + data + '</table>')
    //                           .appendTo('body');
    //            },
    //            error: function (data) {
    //            }
    //        });
    //    });
    //    $(document).click(null, function () {
    //        $('div#relatedPools_popUp').html('');
    //        $('div#relatedPools_popUp').hide();
    //    });
    //});
});