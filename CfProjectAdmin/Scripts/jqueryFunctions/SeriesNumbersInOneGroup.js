$(window).load(function () {
    var seriesId = $("input[name=seriesId]").val();
    var groupFilter = $("input[name=groupFilter]").val();
    var groupType = $("input[name=groupType]").val();
    $().loadMore({
        button: $("#load-more"),
        container: $("#groupnumbers-container"),
        auto: false,
        url: "/Series/SeriesNumbersInOneGroupF?seriesId=" + seriesId + "&groupFilter=" + groupFilter + "&groupType=" + groupType
             + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
                + "&rangeString=" + $("#rangeString").val() + "&classificationString=" + $("#classificationString").val()
                + "&statusString=" + $("#statusString").val()
                + "&poolsString=" + $("#poolsString").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
                + "&relatedPoolsOperator=" + $("#relatedPoolsOperator").val() + "&relatedPoolsValue=" + $("#relatedPoolsValue").val()
                + "&numberPriceOperator=" + $("#numberPriceOperator").val() + "&numberPriceValue=" + $("#numberPriceValue").val()
                + "&totalScoreOperator=" + $("#totalScoreOperator").val() +
                "&totalScoreValue=" + $("#totalScoreValue").val()
                + "&avScoreOperator=" + $("#avScoreOperator").val() +
                "&avScoreValue=" + $("#avScoreValue").val()
        
    });
});