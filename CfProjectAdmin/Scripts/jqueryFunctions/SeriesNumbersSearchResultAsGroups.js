$(document).ready(function () {
    var seriesId = $("input[name=seriesId]").val();
    var url = "&seriesId=" + seriesId + "&matchType=" + $("#matchType").val()
                + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
                + "&classificationString=" + $("#classificationString").val()
                + "&statusString=" + $("#statusString").val()
                + "&relatedPoolsOperator=" + $("#relatedPoolsOperator").val() + "&relatedPoolsValue=" + $("#relatedPoolsValue").val()
                + "&numberPriceOperator=" + $("#numberPriceOperator").val() + "&numberPriceValue=" + $("#numberPriceValue").val()
                + "&totalScoreOperator=" + $("#totalScoreOperator").val() +
                "&totalScoreValue=" + $("#totalScoreValue").val()
                + "&avScoreOperator=" + $("#avScoreOperator").val() +
                "&avScoreValue=" + $("#avScoreValue").val()
                + "&";
    var moveLeft = 20;
    var moveDown = 10;
    $().loadMore({
        button: $("#load-more"),
        container: $("#groups-container"),
        auto: false,
        url: "/Series/seriesNumbersSearchResultAsGroupF?" + url,
    });
    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/Series/seriesNumbersSearchResultAsGroupF?" + url,
    });
    $("input[name=groupByFilter]").filterek({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/Series/seriesNumbersSearchResultAsGroupF?" + url,
    });
    $(document).on('click', '.sort_checkbox', function (e) {
        e.preventDefault();
        var checkedRows = $(".checked-number:checked").closest("tr");
        var cloneCheckedRows = checkedRows.clone();
        var uncheckedRows = $(".checked-number:not(:checked)").closest("tr");
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
    $('#exportSelectedNumbers').on('click', function (e) {
        e.preventDefault();
        var groupFilter = $(".filter_value").val();
        var groups = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            groups.push($(this).attr("id"));
        });
        var count = groups.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any group",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $(".hiddenInput").remove();
            $("#myForm").append("<input type = 'hidden' name='exortType' value='selected' class='hiddenInput' />");
            $("#myForm").append("<input type = 'hidden' name='grouping' value='yes' class='hiddenInput' />");
            $("#myForm").append("<input type = 'hidden' name='selectedNumbers' value='" + groups + "' class='hiddenInput'/>");
            $("#myForm").append("<input type = 'hidden' name='fromSearch' value='yes' class='hiddenInput' />");
            $("#myForm").append("<input type = 'hidden' name='groupFilter' value='" + groupFilter + "' class='hiddenInput'/>");
            $("#myForm").submit();
        }
    });
    $('#exportAllNumbers').on('click', function (e) {
        e.preventDefault();
        var groupFilter = $(".filter_value").val();
        $(".hiddenInput").remove();
        $("#myForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput' />");
        $("#myForm").append("<input type = 'hidden' name='grouping' value='yes' class='hiddenInput' />");
        $("#myForm").append("<input type = 'hidden' name='fromSearch' value='yes' class='hiddenInput' />");
        $("#myForm").append("<input type = 'hidden' name='groupFilter' value='" + groupFilter + "' class='hiddenInput'/>");
        $("#myForm").submit();
    });
})