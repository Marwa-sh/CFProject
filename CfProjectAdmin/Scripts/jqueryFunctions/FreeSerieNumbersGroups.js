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
    $().loadMore({
        button: $("#load-more"),
        container: $("#groups-container"),
        auto: false,
        url: "/FreeSeries/getFreeSerieNumbersGroupF?"+ url,
    });

    $("input[name=groupByFilter]").filterek({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/FreeSeries/getFreeSerieNumbersGroupF?" + url,
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/FreeSeries/getFreeSerieNumbersGroupF?" + url,
    });

    $(document).on('click', '.sort_checkbox', function (e) {
        e.preventDefault();
        var checkedRows = $(".checked-group:checked").closest("tr");
        var cloneCheckedRows = checkedRows.clone();
        var uncheckedRows = $(".checked-group:not(:checked)").closest("tr");
        var cloneUncheckedRows = uncheckedRows.clone();
        var header = $("#groups-container tr").first().clone();
        $("#groups-container").html("");
        $("#groups-container").append(header);
        cloneCheckedRows.each(function () {
            $("#groups-container").append($(this));
        });
        cloneUncheckedRows.each(function () {
            $("#groups-container").append($(this));
        });
    });
});