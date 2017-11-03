$(document).ready(function () {
    var numberType = $("input[name=numberType]").val();
    var moveLeft = 20;
    var moveDown = 10;
    var url = "&matchType=" + $("#matchType").val()
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
                + "&";
    $().loadMore({
        button: $("#load-more"),
        container: $("#groups-container"),
        auto: false,
        url: "/Numbers/NumbersSearchResultAsGroupF?numberType=" + numberType + url,
    });
    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/Numbers/NumbersSearchResultAsGroupF?numberType=" + numberType + url,
    });
    $("input[name=groupByFilter]").filterek({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/Numbers/NumbersSearchResultAsGroupF?numberType=" + numberType + url,
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
    $("#deleteAll").on('click', function (e) {
        e.preventDefault();
        var numbers = [];
        var status = [];
        var isSeries = [];
        $.msgBox({
            title: 'Delete Numbers ',
            content: 'Are You Sure you want to Delete All numbers?',
            type: "prompt",
            inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if ($("input[name=password]").val() == "")
                    $.msgBox({
                        title: 'WARNING',
                        content: "Error Password",
                        opacity: 0.5,
                        buttons: [{ value: "OK" }],
                        success: function (result) {
                            if (result == "OK")
                                location.reload();
                        }
                    })
                else {
                    if (result == "Yes") {
                        var numbers = [];
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Numbers/DeleteNumbers?fromSearch=yes" + url,                            
                            type: "POST",
                            data: { numberType: numberType, selectedNumbersIds: numbers, selectedNumbersStatus: status, selctedNumbersIsSeries: isSeries },
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
    $("#activeAll").on('click', function (e) {
        e.preventDefault();
        var numbers = [];
        $.msgBox({
            title: 'Active Numbers ',
            content: 'Are You Sure you want to Active All numbers?',
            type: "prompt",
            inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if ($("input[name=password]").val() == "")
                    $.msgBox({
                        title: 'WARNING',
                        content: "Error Password",
                        opacity: 0.5,
                        buttons: [{ value: "OK" }],
                        success: function (result) {
                            if (result == "OK")
                                location.reload();
                        }
                    })
                else {
                    if (result == "Yes") {
                        var numbers = [];
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Numbers/ActiveNumbers?fromSearch=yes" + url,
                            type: "POST",
                            data: { selectedNumbersIds: numbers },
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
    $("#activeSelected").on('click', function (e) {
        e.preventDefault();
        var groups = [];
        var groupFilter = $(".filter_value").val();
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
                title: 'Active Numbers',
                content: 'Are You Sure you want to active ' + count + ' group(s)? ',
                type: "prompt",
                inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],

                success: function (result) {
                    var pass = $("input[name=password]").val();
                    if (pass == "")
                        $.msgBox({
                            title: 'WARNING',
                            content: "Error Password",
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                            success: function (result) {
                                if (result == "OK")
                                    location.reload();
                            }
                        })
                    else {
                        if (result == "Yes") {
                            $('body').addClass('wait');
                            $.ajax({
                                url: "/Numbers/ActiveNumbers?fromSearch=yes&grouping=yes&groupFilter=" + groupFilter + "&numberType=" + numberType + url,
                                type: "POST",
                                data: { selectedNumbersIds: groups },
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
    $("#deleteSelected").on('click', function (e) {
        e.preventDefault();
        var groups = [];
        var status = [];
        var isSeries = [];
        var groupFilter = $(".filter_value").val();
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
                title: 'Delete Numbers',
                content: 'Are You Sure you want to delete ' + count + ' group(s)? ',
                type: "prompt",
                inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],

                success: function (result) {
                    var pass = $("input[name=password]").val();
                    if (pass == "")
                        $.msgBox({
                            title: 'WARNING',
                            content: "Error Password",
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                            success: function (result) {
                                if (result == "OK")
                                    location.reload();
                            }
                        })
                    else {
                        if (result == "Yes") {
                            $('body').addClass('wait');
                            $.ajax({
                                url: "/Numbers/DeleteNumbers?fromSearch=yes&grouping=yes&groupFilter=" + groupFilter + url,
                                type: "POST",
                                data: { numberType: numberType, selectedNumbersIds: groups, selectedNumbersStatus: status, selctedNumbersIsSeries: isSeries },
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
            $("#myForm").append("<input type = 'hidden' name='numberType' value='" + numberType + "' class='hiddenInput'/>");
            $("#myForm").append("<input type = 'hidden' name='groupFilter' value='" + groupFilter + "' class='hiddenInput'/>");
            $("#myForm").append("<input type = 'hidden' name='fromSearch' value='yes' class='hiddenInput' />");
            $("#myForm").submit();
        }
    });
    $('#exportAllNumbers').on('click', function (e) {
        e.preventDefault();
        var groupFilter = $(".filter_value").val();
        $(".hiddenInput").remove();
        $("#myForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput' />");
        $("#myForm").append("<input type = 'hidden' name='grouping' value='yes' class='hiddenInput' />");
        $("#myForm").append("<input type = 'hidden' name='numberType' value='" + numberType + "' class='hiddenInput'/>");
        $("#myForm").append("<input type = 'hidden' name='groupFilter' value='" + groupFilter + "' class='hiddenInput'/>");
        $("#myForm").append("<input type = 'hidden' name='fromSearch' value='yes' class='hiddenInput' />");
        $("#myForm").submit();
    });
})