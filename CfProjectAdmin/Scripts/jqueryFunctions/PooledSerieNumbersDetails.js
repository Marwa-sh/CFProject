$(window).load(function () {
    var url = "&matchType=" + $("#matchType").val()
                + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
                + "&rangeString=" + $("#rangeString").val() + "&classificationString=" + $("#classificationString").val()
                + "&statusString=" + $("#statusString").val()
                + "&poolsString=" + $("#poolsString").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
                + "&relatedPoolsOperator=" + $("#relatedPoolsOperator").val() + "&relatedPoolsValue=" + $("#relatedPoolsValue").val()
                + "&totalScoreOperator=" + $("#totalScoreOperator").val() +
                "&totalScoreValue=" + $("#totalScoreValue").val()
                + "&avScoreOperator=" + $("#avScoreOperator").val() +
                "&avScoreValue=" + $("#avScoreValue").val()
                + "&";
    var moveLeft = 20;
    var moveDown = 10;
    var serieID = $("input[name=serieID]").attr("value");
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreeSeries/PooledSerieNumbersSearchResultF?" + url,
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreeSeries/PooledSerieNumbersSearchResultF?" + url,
    });

    $("#data-search").search({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreeSeries/PooledSerieNumbersSearchResultF?" + url,
    });


    $(document).on('click', '#exportAllNumbers', function (e) {
        e.preventDefault();
        $("sampleForm").submit();
    });

    $(document).on('click', '.relatedPools', function (e) {
        e.preventDefault();
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