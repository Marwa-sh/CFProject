$(window).load(function () {
    var groupFilter = $("input[name=groupFilter]").val();
    var groupType = $("input[name=groupType]").val();

    $().loadMore({
        button: $("#load-more"),
        container: $("#groupnumbers-container"),
        auto: false,
        url: "/Pools/getAllNumbersOfNormalPoolGroupF?" + "poolId=" + $("#poolId").val() + "&groupFilter=" + groupFilter + "&groupType=" + groupType + "&matchType=" + $("#matchType").val()
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