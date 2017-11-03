$(window).load(function () {
    var serieID = $("input[name=serieID]").attr("value");
    var url = "&matchType=" + $("#matchType").val()
                + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
                + "&rangeString=" + $("#rangeString").val() + "&classificationString=" + $("#classificationString").val()
                + "&statusString=" + $("#statusString").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
                 + "&numberPriceOperator=" + $("#numberPriceOperator").val() + "&numberPriceValue=" + $("#numberPriceValue").val()
                 + "&totalScoreOperator=" + $("#totalScoreOperator").val() +
                "&totalScoreValue=" + $("#totalScoreValue").val()
                + "&avScoreOperator=" + $("#avScoreOperator").val() +
                "&avScoreValue=" + $("#avScoreValue").val()
                + "&serieID=" + serieID + "&";
    var moveLeft = 20;
    var moveDown = 10;
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        auto:false,
        url: "/FreeSeries/FreeSerieNumbersSearchResultF?" + url,
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreeSeries/FreeSerieNumbersSearchResultF?" + url,
    });

    $("#data-search").search({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreeSeries/FreeSerieNumbersSearchResultF?" + url,
    });


    $(document).on('click', '#exportAllNumbers', function (e) {
        e.preventDefault();
        $("sampleForm").submit();
    });

    $(document).on('click', '.relatedPools', function (e) {
        e.preventDefault();
        $('div#relatedPools_popUp').show()
                          .css('top', e.pageY + moveDown)
                          .css('left', e.pageX + moveLeft)
                          .appendTo('body');
    });
    $(document).click(null, function (e) {
        if (!$(e.target).parents().andSelf().is('.relatedPools')) {
            $('div#relatedPools_popUp').hide();
        }
    });

});