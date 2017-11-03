$(document).ready(function () {
    var url = "/FreeNumbers/pooledNumbersSearchResultAsGroupF?matchType=" + $("#matchType").val()
                + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
                + "&rangeString=" + $("#range").val() + "&classificationString=" + $("#classification").val()
                + "&poolsString=" + $("#pools").val()
                + "&statusString=" + $("#status").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
                + "&relatedPoolsOperator=" + $("#relatedPoolsOperator").val() + "&relatedPoolsValue=" + $("#relatedPoolsValue").val()
                + "&numberPriceOperator=" + $("#numberPriceOperator").val() + "&numberPriceValue=" + $("#numberPriceValue").val()
                + "&totalScoreOperator=" + $("#totalScoreOperator").val() +
                "&totalScoreValue=" + $("#totalScoreValue").val()
                + "&avScoreOperator=" + $("#avScoreOperator").val() +
                "&avScoreValue=" + $("#avScoreValue").val()
                + "&";
    var urlForFunctions = "fromSearch=YES"
               + "&matchType=" + $("#matchType").val()
               + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
               + "&rangeString=" + $("#range").val() + "&classificationString=" + $("#classification").val()
               + "&poolsString=" + $("#pools").val()
               + "&statusString=" + $("#status").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
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
        url: url,
    });
    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: url,
    });
    $("input[name=groupByFilter]").filterek({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: url,
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
    $('#releaseSelectedGroups').on('click', function () {
        var groups = [];
        var appendedVarInUri = $(".filter_value").val();
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
            $.msgBox({
                title: 'release Groups',
                content: 'Are You Sure you want to release ' + count + ' group(s)?',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/FreeNumbers/releaseGroups?" + urlForFunctions + appendedVarInUri,
                            type: "POST",
                            data: { selectedGroups: groups },
                            dataType: "json",
                            traditional: true,
                            cache: false,
                            async: true,
                            success: function (json) {
                                $.msgBox({
                                    title: 'success msg',
                                    content: json,
                                    type: "success",
                                    opacity: 0.5,
                                    buttons: [{ value: "OK" }],
                                    success: function (result) {
                                        if (result == "OK")
                                            location.reload();
                                    }
                                })
                            },
                            complete: function () {
                                $('body').removeClass('wait');
                            }
                        });
                    }
                }
            })
        }
    });

    $('#releaseAllNumbers').on('click', function () {
        $.msgBox({
            title: 'Release Numbers ',
            content: 'Are You Sure you want to release All numbers?',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    var numbers = [];
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/FreeNumbers/ReleaseNumbers?" + urlForFunctions,
                        type: "POST",
                        data: { selectedNumbers: numbers },
                        dataType: "json",
                        traditional: true,
                        cache: false,
                        async: true,
                        success: function (json) {
                            $.msgBox({
                                title: 'success msg',
                                content: json,
                                type: "success",
                                opacity: 0.5,
                                buttons: [{ value: "OK" }],
                                success: function (result) {
                                    if (result == "OK")
                                        location.reload();
                                }
                            })
                        },
                        complete: function () {
                            $('body').removeClass('wait');
                        }
                    });
                }
            }
        });
    });
    $('#exportSelectedGroups').on('click', function (e) {
        e.preventDefault();
        var groups = [];
        var appendedVarInUri = $(".filter_value").val();
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
            $("#myForm").append("<input type = 'hidden' name='groupFilterVal' value='" + appendedVarInUri + "'  class='hiddenInput'/>");
            $("#myForm").append("<input type = 'hidden' name='exortType' value='selected' class='hiddenInput' />");
            $("#myForm").append("<input type ='hidden' name='fromSearch' value='YES' class='hiddenInput' />");
            $("#myForm").append("<input type = 'hidden' name='selectedGroups' value='" + groups + "' class='hiddenInput' />");
            $("#myForm").submit();
        }
    });
    $('#exportAllGroups').on('click', function (e) {
        e.preventDefault();
        var appendedVarInUri = $(".filter_value").val();
        $(".hiddenInput").remove();
        $("#myForm").append("<input type = 'hidden' name='groupFilterVal' value='" + appendedVarInUri + "'  class='hiddenInput'/>");
        $("#myForm").append("<input type ='hidden' name='fromSearch' value='YES' class='hiddenInput' />");
        $("#myForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput' />");
        $("#myForm").submit();
    });
})