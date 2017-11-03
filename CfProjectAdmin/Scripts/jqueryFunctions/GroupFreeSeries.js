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
        url: "/FreeSeries/groupFreeSeriesF?" + url,
    });
    $("input[name=groupByFilter]").filterek({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/FreeSeries/groupFreeSeriesF?" + url,
    });
    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/FreeSeries/groupFreeSeriesF?" + url,
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

   
    $('#exportSelectedGroups').on('click', function () {
        var groups = [];
        $('input[name=checkedGroup]:checked').each(function () {
            groups.push($(this).attr("value"));
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
            $("#sampleForm").append("<input type = 'hidden' name='exortType' value='selected' class='hiddenInput' />");
            $("#sampleForm").append("<input type = 'hidden' name='selectedGroups' value='" + groups + "' class='hiddenInput'/>");
            $("#sampleForm").submit();
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
                content: "Groups Of Series List Empty",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $(".hiddenInput").remove();
            $("#sampleForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput' />");
            $("#sampleForm").append("<input type = 'hidden' name='selectedGroups' value='" + groups + "' class='hiddenInput'/>");
            $("#sampleForm").submit();
        }
    });

    $('#poolingSelectedGroupsToAdmin').on('click', function () {
        var groups = [];
        $('input[name=checkedGroup]:checked').each(function () {
            groups.push($(this).attr("value"));
        });
        var count = groups.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any group",
                opacity: 0.0,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Pooling Groups of Series',
                content: 'Only available series will be pooled',
                type: "prompt",
                opacity: 0.0,
                buttons: [{ value: "Yes" }, { value: "No" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#adminDesPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool ' + count + ' group(s) of series ?' + '</p>');
                },
                success: function (result) {
                    if (result == "Yes") {
                        var pools = [];
                        $('input[name=checkedPools]:checked').each(function () {
                            pools.push($(this).attr("id"));
                        });
                        var count = pools.length;
                        if (count == 0) {
                            $.msgBox({
                                title: 'WARNING',
                                content: "You didn't select any pool",
                                opacity: 0.0,
                                buttons: [{ value: "OK" }],
                            })
                        } else {
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
                                                        url: "/FreeSeries/PoolingGroupSeries?" + url,
                                                        type: "POST",
                                                        data: { selectedPools: pools.toString(), selectedGroups: groups.toString(), approvalType: "ADMIN" },
                                                        dataType: "json",
                                                        traditional: true,
                                                        cache: false,
                                                        async: true,
                                                        success: function (json) {
                                                            $.msgBox({
                                                                title: 'success msg',
                                                                content: json,
                                                                type: "success",
                                                                opacity: 0.0,
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
                                    else
                                        return true;
                                }
                            })
                        }
                    }
                    else return true;
                }
            });
        }
    });

    $('#poolingSelectedGroupsToEndUser').on('click', function () {
        var groups = [];
        $('input[name=checkedGroup]:checked').each(function () {
            groups.push($(this).attr("value"));
        });
        var count = groups.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any serie",
                opacity: 0.0,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Pooling Groups Series',
                content: 'Only available series will be pooled',
                type: "prompt",
                opacity: 0.0,
                buttons: [{ value: "Yes" }, { value: "No" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#endUserDesPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool ' + count + ' group(s) of series ?' + '</p>');
                },
                success: function (result) {
                    if (result == "Yes") {
                        var pools = [];
                        $('input[name=checkedPools]:checked').each(function () {
                            pools.push($(this).attr("id"));
                        });
                        var count = pools.length;
                        if (count == 0) {
                            $.msgBox({
                                title: 'WARNING',
                                content: "You didn't select any pool",
                                opacity: 0.0,
                                buttons: [{ value: "OK" }],
                            })
                        }
                        else {
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
                                                        url: "/FreeSeries/PoolingGroupSeries?" + url,
                                                        type: "POST",
                                                        data: { selectedPools: pools.toString(), selectedGroups: groups.toString(), approvalType: "ENDUSER" },
                                                        dataType: "json",
                                                        traditional: true,
                                                        cache: false,
                                                        async: true,
                                                        success: function (json) {
                                                            $.msgBox({
                                                                title: 'success msg',
                                                                content: json,
                                                                type: "success",
                                                                opacity: 0.0,
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
                                    else
                                        return true;
                                }
                            })
                        }
                    }
                    else return true;
                }
            });
        }
    });

    $('#poolingAllToAdmin').on('click', function () {
        $.msgBox({
            title: 'Pooling All Groups of Series',
            content: 'Only available series will be pooled',
            type: "prompt",
            opacity: 0.0,
            buttons: [{ value: "Yes" }, { value: "No" }],
            inputContainerId: "destinationPools",
            beforeShow: function () {
                $("#destinationPools").html('');
                $("#destinationPools").append('<table>' + $("#adminDesPools").val() + '</table>');
                $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool All groups of series ?' + '</p>');
            },
            success: function (result) {
                if (result == "Yes") {
                    var pools = [];
                    $('input[name=checkedPools]:checked').each(function () {
                        pools.push($(this).attr("id"));
                    });
                    var count = pools.length;
                    if (count == 0) {
                        $.msgBox({
                            title: 'WARNING',
                            content: "You didn't select any pool",
                            opacity: 0.0,
                            buttons: [{ value: "OK" }],
                        })
                    }
                    else {
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
                                                var groups = [];
                                                $('input[name=checkedGroup]').each(function () {
                                                    groups.push($(this).attr("value"));
                                                });
                                                $('body').addClass('wait');
                                                $.ajax({
                                                    url: "/FreeSeries/PoolingGroupSeries?" + url,
                                                    type: "POST",
                                                    data: { selectedPools: pools.toString(), selectedGroups: null, approvalType: "ADMIN" },
                                                    dataType: "json",
                                                    traditional: true,
                                                    cache: false,
                                                    async: true,
                                                    success: function (json) {
                                                        $.msgBox({
                                                            title: 'success msg',
                                                            content: json,
                                                            type: "success",
                                                            opacity: 0.0,
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
                                else
                                    return true;
                            }
                        })
                    }
                }
                else return true;
            }
        });
    });

    $('#poolingAllToEndUser').on('click', function () {
        $.msgBox({
            title: 'Pooling All Groups of Series',
            content: 'Only available series will be pooled',
            type: "prompt",
            opacity: 0.0,
            buttons: [{ value: "Yes" }, { value: "No" }],
            inputContainerId: "destinationPools",
            beforeShow: function () {
                $("#destinationPools").html('');
                $("#destinationPools").append('<table>' + $("#endUserDesPools").val() + '</table>');
                $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool All groups series ?' + '</p>');
            },
            success: function (result) {
                if (result == "Yes") {
                    var pools = [];
                    $('input[name=checkedPools]:checked').each(function () {
                        pools.push($(this).attr("id"));
                    });
                    var count = pools.length;
                    if (count == 0) {
                        $.msgBox({
                            title: 'WARNING',
                            content: "You didn't select any pool",
                            opacity: 0.0,
                            buttons: [{ value: "OK" }],
                        })
                    } else {
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
                                                var groups = [];
                                                $('input[name=checkedGroup]').each(function () {
                                                    groups.push($(this).attr("value"));
                                                });
                                                $('body').addClass('wait');
                                                $.ajax({
                                                    url: "/FreeSeries/PoolingGroupSeries?" + url,
                                                    type: "POST",
                                                    data: { selectedPools: pools.toString(), selectedGroups: null, approvalType: "ENDUSER" },
                                                    dataType: "json",
                                                    traditional: true,
                                                    cache: false,
                                                    async: true,
                                                    success: function (json) {
                                                        $.msgBox({
                                                            title: 'success msg',
                                                            content: json,
                                                            type: "success",
                                                            opacity: 0.0,
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
                                else
                                    return true;
                            }
                        })
                    }
                }
                else return true;
            }
        });
    });
});