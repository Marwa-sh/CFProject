$(document).ready(function () {
    var url = "matchType=" + $("#matchType").val()
                + "&matchText=" + $("#matchText").val() + "&matchAllAny="+$("#matchAllAny").val()
                + "&rangeString=" + $("#range").val() + "&classificationString=" + $("#classification").val()
                + "&statusString=" + $("#status").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
                + "&numberPriceOperator=" + $("#numberPriceOperator").val() + "&numberPriceValue=" + $("#numberPriceValue").val()
                 + "&totalScoreOperator=" + $("#totalScoreOperator").val() +
                "&totalScoreValue=" + $("#totalScoreValue").val()
                + "&avScoreOperator=" + $("#avScoreOperator").val() +
                "&avScoreValue=" + $("#avScoreValue").val()
                + "&";
    $().loadMore({
        button: $("#load-more"),
        container: $("#groups-container"),
        auto: false,
        url: "/FreeNumbers/freeNumbersSearchResultAsGroupF?" + url,
    });
    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/FreeNumbers/freeNumbersSearchResultAsGroupF?" + url,
    });
    $("input[name=groupByFilter]").filterek({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/FreeNumbers/freeNumbersSearchResultAsGroupF?" + url,
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
    $('#poolingSelectedGroupsToAdmin').on('click', function () {
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
                title: 'Pooling Groups',
                content: 'Are You Sure you want to pooling ' + count + ' group(s)?',
                type: "prompt",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#adminDesPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to pooling ' + count + ' group(s)?' + '</p>');
                },
                success: function (result) {
                    if (result == "Yes") {
                        var numbers = [];
                        $('input[name=checkedNumbers]:checked').each(function () {
                            numbers.push($(this).attr("id"));
                        });
                        var pools = [];
                        $('input[name=checkedPools]:checked').each(function () {
                            pools.push($(this).attr("id"));
                        });
                        var count = pools.length;
                        if (count == 0) {
                            $.msgBox({
                                title: 'WARNING',
                                content: "You didn't select any pool",
                                opacity: 0.5,
                                buttons: [{ value: "OK" }],
                            })
                        }
                        else {
                            $('body').addClass('wait');
                            $.ajax({
                                url: "/FreeNumbers/poolingGroups?fromSearch=YES&" + url + appendedVarInUri,
                                type: "POST",
                                data: { selectedPools: pools, selectedGroups: numbers },
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
                }
            });
        }
    });
    $('#poolingSelectedGroupsToEndUser').on('click', function () {
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
                title: 'Pooling Groups',
                content: 'Are You Sure you want to pooling ' + count + ' group(s)?',
                type: "prompt",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#endUserDesPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to pooling ' + count + ' group(s)?' + '</p>');
                },
                success: function (result) {
                    if (result == "Yes") {
                        var numbers = [];
                        $('input[name=checkedNumbers]:checked').each(function () {
                            numbers.push($(this).attr("id"));
                        });
                        var pools = [];
                        $('input[name=checkedPools]:checked').each(function () {
                            pools.push($(this).attr("id"));
                        });
                        var count = pools.length;
                        if (count == 0) {
                            $.msgBox({
                                title: 'WARNING',
                                content: "You didn't select any pool",
                                opacity: 0.5,
                                buttons: [{ value: "OK" }],
                            })
                        }
                        else {
                            $('body').addClass('wait');
                            $.ajax({
                                url: "/FreeNumbers/poolingGroups?fromSearch=YES&" + url + appendedVarInUri,
                                type: "POST",
                                data: { selectedPools: pools, selectedGroups: numbers },
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
                }
            });
        }
    });
    $('#poolingAllToAdmin').on('click', function () {
        $.msgBox({
            title: 'Pooling All Numbers',
            content: 'Only available numbers will be pooled',
            type: "prompt",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            inputContainerId: "destinationPools",
            beforeShow: function () {
                $("#destinationPools").html('');
                $("#destinationPools").append('<table>' + $("#adminDesPools").val() + '</table>');
                $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool All numbers ?' + '</p>');
            },
            success: function (result) {
                if (result == "Yes") {
                    var pools = [];
                    var numbers = [];
                    $('input[name=checkedPools]:checked').each(function () {
                        pools.push($(this).attr("id"));
                    });
                    var count = pools.length;
                    if (count == 0) {
                        $.msgBox({
                            title: 'WARNING',
                            content: "You didn't select any pool",
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                        })
                    }
                    else {
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/FreeNumbers/PoolingNumbers?fromSearch=YES&" + url,
                            type: "POST",
                            data: { selectedPools: pools, selectedNumbers: numbers },
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
            }
        });
    });
    $('#poolingAllToEndUser').on('click', function () {
        $.msgBox({
            title: 'Pooling All Numbers',
            content: 'Only available numbers will be pooled',
            type: "prompt",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            inputContainerId: "destinationPools",
            beforeShow: function () {
                $("#destinationPools").html('');
                $("#destinationPools").append('<table>' + $("#endUserDesPools").val() + '</table>');
                $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool All numbers ?' + '</p>');
            },
            success: function (result) {
                if (result == "Yes") {
                    var pools = [];
                    var numbers = [];
                    $('input[name=checkedPools]:checked').each(function () {
                        pools.push($(this).attr("id"));
                    });
                    var count = pools.length;
                    if (count == 0) {
                        $.msgBox({
                            title: 'WARNING',
                            content: "You didn't select any pool",
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                        })
                    }
                    else {
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/FreeNumbers/PoolingNumbers?fromSearch=YES&" + url,
                            type: "POST",
                            data: { selectedPools: pools, selectedNumbers: numbers },
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