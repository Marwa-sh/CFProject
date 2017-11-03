$(window).load(function () {
    var url = "&matchType=" + $("#matchType").val()
                + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
                + "&rangeString=" + $("#rangeString").val() + "&classificationString=" + $("#classificationString").val()
                + "&poolsString=" + $("#poolsString").val()
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
        url: "/FreezedSeries/groupUNfreezedSeriesF?" + url,
    });
    $("input[name=groupByFilter]").filterek({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/FreezedSeries/groupUNfreezedSeriesF?" + url,
    });
    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/FreezedSeries/groupUNfreezedSeriesF?" + url,
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

    $(document).on('click', '#freezeSelectedGroup', function (e) {
        e.preventDefault();
        var selectedGroups = [];
        $("input[name='checkedGroup']:checked").each(function () {
            selectedGroups.push(this.value);
        });
        var count = selectedGroups.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any group of series",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Freeze Groups Of Series',
                content: 'Are You Sure you want to freeze ' + count + 'group(s) of series? ',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        $.msgBox({
                            title: 'Enter Your Password',
                            type: "prompt",
                            inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
                            opacity: 0.5,
                            buttons: [{ value: "Yes" }, { value: "No" }],
                            success: function (result) {
                                if (result == "Yes") {
                                    var pass = $("input[name=password]").val();
                                    $.ajax({
                                        url: "/MemberManagement/validateSuperActionPassword",
                                        type: "POST",
                                        data: { userPassword: pass },
                                        dataType: "json",
                                        traditional: true,
                                        cache: false,
                                        async: true,
                                        success: function (data) {
                                            if (data == false)
                                                $.msgBox({
                                                    title: 'WARNING',
                                                    content: "Error Password",
                                                    opacity: 0.5,
                                                    buttons: [{ value: "OK" }],
                                                    success: function (result) {
                                                        if (result == "OK")
                                                            return true;
                                                    }
                                                })
                                            else {
                                                $('body').addClass('wait');
                                                $.ajax({
                                                    url: "/FreezedSeries/freezeSelectedGroupSeries?" + url,
                                                    type: "GET",
                                                    data: { groupType: selectedGroups.toString() },
                                                    dataType: "json",
                                                    traditional: true,
                                                    cache: false,
                                                    async: true,
                                                    success:
                                                        function (data) {
                                                            if (data.status) {
                                                                $.msgBox({
                                                                    title: 'success msg',
                                                                    content: count + data.message,
                                                                    type: "success",
                                                                    opacity: 0.5,
                                                                    buttons: [{ value: "OK" }],
                                                                    success: function (result) {
                                                                        if (result == "OK")
                                                                            location.reload();
                                                                    }
                                                                })
                                                            }
                                                            else
                                                                $.msgBox({
                                                                    title: 'WARNING',
                                                                    content: "Freeze groups of series failed.",
                                                                    opacity: 0.5,
                                                                    buttons: [{ value: "OK" }],
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
                                else
                                    return true;
                            }
                        })
                    }
                    else return true;
                }
            })
        }
    });


    $(document).on('click', '#freezeAllGroup', function (e) {
        e.preventDefault();
        var groups = [];
        $("input[name='checkedGroup']").each(function () {
            groups.push(this.value);
        });
        var count = groups.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "Groups of series List Empty",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Freeze Groups Of Series',
                content: 'Are You Sure you want to freeze all groups of series? ',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        $.msgBox({
                            title: 'Enter Your Password',
                            type: "prompt",
                            inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
                            opacity: 0.5,
                            buttons: [{ value: "Yes" }, { value: "No" }],
                            success: function (result) {
                                if (result == "Yes") {
                                    var pass = $("input[name=password]").val();
                                    $.ajax({
                                        url: "/MemberManagement/validateSuperActionPassword",
                                        type: "POST",
                                        data: { userPassword: pass },
                                        dataType: "json",
                                        traditional: true,
                                        cache: false,
                                        async: true,
                                        success: function (data) {
                                            if (data == false)
                                                $.msgBox({
                                                    title: 'WARNING',
                                                    content: "Error Password",
                                                    opacity: 0.5,
                                                    buttons: [{ value: "OK" }],
                                                    success: function (result) {
                                                        if (result == "OK")
                                                            return true;
                                                    }
                                                })
                                            else {
                                                $('body').addClass('wait');
                                                $.ajax({
                                                    url: "/FreezedSeries/freezeAllSeries?" + url,
                                                    type: "GET",
                                                    data: "",
                                                    dataType: "json",
                                                    traditional: true,
                                                    cache: false,
                                                    async: true,
                                                    success:
                                                        function (data) {
                                                            if (data.status)
                                                                $.msgBox({
                                                                    title: 'success msg',
                                                                    content: data.message,
                                                                    type: "success",
                                                                    opacity: 0.5,
                                                                    buttons: [{ value: "OK" }],
                                                                    success: function (result) {
                                                                        if (result == "OK")
                                                                            location.reload();
                                                                    }
                                                                })
                                                            else
                                                                $.msgBox({
                                                                    title: 'WARNING',
                                                                    content: "Freeze groups of series failed.",
                                                                    opacity: 0.5,
                                                                    buttons: [{ value: "OK" }],
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
                                else
                                    return true;
                            }
                        })
                    }
                    else return true;
                }
            })
        }
    });


    $('#exportSelectedGroups').on('click', function () {
        var groups = [];
        $('input[name=checkedGroup]:checked').each(function () {
            groups.push($(this).attr("value"));
        });
        var count = groups.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any group of series",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $('#sampleForm').append("<input type = 'hidden' name='exortType' value='selected' />");
            $('#sampleForm').append("<input type = 'hidden' name='selectedGroups' value='" + groups + "'/>");
            $('#sampleForm').submit();
        }
    });

    $('#exportAllGroups').on('click', function (e) {
        e.preventDefault();
        var groups = [];
        $('input[name=checkedGroup]').each(function () {
            groups.push($(this).attr("value"));
        });
        var count = groups.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "Groups of series List Empty",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $('#sampleForm').append("<input type = 'hidden' name='exortType' value='all' />");
            $('#sampleForm').submit();
        }
    });

});