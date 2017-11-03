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
    var moveLeft = 20;
    var moveDown = 10;
    $().loadMore({
        button: $("#load-more"),
        container: $("#series-container"),
        auto: false,
        url: "/FreeSeries/FreeSeriesSearchResultF?" + url,
    });   

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#series-container"),
        url: "/FreeSeries/FreeSeriesSearchResultF?" + url,
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
    $(document).on('click', '#sort_checkbox', function (e) {
        e.preventDefault();
        var checkedRows = $(".checked-serie:checked").closest("tr");
        var cloneCheckedRows = checkedRows.clone();
        var uncheckedRows = $(".checked-serie:not(:checked)").closest("tr");
        var cloneUncheckedRows = uncheckedRows.clone();
        var header = $("#series-container tr").first().clone();
        $("#series-container").html("");
        $("#series-container").append(header);
        cloneCheckedRows.each(function () {
            $("#series-container").append($(this));
        });
        cloneUncheckedRows.each(function () {
            $("#series-container").append($(this));
        });
    });

    $('#poolingSelectedSeriesToAdmin').on('click', function () {
        var seriesList = [];
        $('input[name=checkedSeries]:checked').each(function () {
            seriesList.push($(this).attr("value"));
        });
        var count = seriesList.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any serie",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Pooling Series',
                content: 'Only available series will be pooled',
                type: "prompt",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#adminDesPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool ' + count + ' series ?' + '</p>');
                },
                success: function (result) {
                    if (result == "Yes") {
                        var pools = [];
                        $('input[name=checkedPools]:checked').each(function () {
                            pools.push($(this).attr("id"));
                        });
                        if (pools.length == 0) {
                            $.msgBox({
                                title: 'WARNING',
                                content: "You didn't select any pool",
                                opacity: 0.5,
                                buttons: [{ value: "OK" }],
                                success: function (result) {
                                    if (result == "OK")
                                        return true;
                                }
                            });
                            return true;
                        }
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
                                                        url: "/FreeSeries/PoolingSeries?" + url,
                                                        type: "POST",
                                                        data: { selectedPools: pools.toString(), selectedSeries: seriesList.toString(), approvalType: "ADMIN" },
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
                                                                },
                                                                complete: function () {
                                                                    $('body').removeClass('wait');
                                                                }
                                                            })
                                                        }
                                                    });
                                                }
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
            });
        }
    });

    $('#poolingSelectedSeriesToEndUser').on('click', function () {        
        var seriesList = [];
        $('input[name=checkedSeries]:checked').each(function () {
            seriesList.push($(this).attr("value"));
        });
        var count = seriesList.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any serie",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Pooling Series',
                content: 'Only available series will be pooled',
                type: "prompt",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#endUserDesPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool ' + count + ' series ?' + '</p>');
                },
                success: function (result) {
                    if (result == "Yes") {
                        var pools = [];
                        $('input[name=checkedPools]:checked').each(function () {
                            pools.push($(this).attr("id"));
                        });
                        if (pools.length == 0) {
                            $.msgBox({
                                title: 'WARNING',
                                content: "You didn't select any pool",
                                opacity: 0.5,
                                buttons: [{ value: "OK" }],
                                success: function (result) {
                                    if (result == "OK")
                                        return true;
                                }
                            });
                            return true;
                        }
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
                                                        url: "/FreeSeries/PoolingSeries?" + url,
                                                        type: "POST",
                                                        data: { selectedPools: pools.toString(), selectedSeries: seriesList.toString(), approvalType: "ENDUSER" },
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
                                    })
                                }
                                else
                                    return true;
                            }
                        })
                    }
                    else return true;
                }
            });
        }
    });

    $('#poolingAllToAdmin').on('click', function () {
        $.msgBox({
            title: 'Pooling All Series',
            content: 'Only available series will be pooled',
            type: "prompt",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            inputContainerId: "destinationPools",
            beforeShow: function () {
                $("#destinationPools").html('');
                $("#destinationPools").append('<table>' + $("#adminDesPools").val() + '</table>');
                $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool All series ?' + '</p>');
            },
            success: function (result) {
                if (result == "Yes") {
                    var pools = [];
                    $('input[name=checkedPools]:checked').each(function () {
                        pools.push($(this).attr("id"));
                    });
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
                                                    url: "/FreeSeries/PoolingSeries?" + url,
                                                    type: "POST",
                                                    data: { selectedPools: pools.toString(), selectedSeries: null, approvalType: "ADMIN" },
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
                                })
                            }
                            else
                                return true;
                        }
                    })
                }
                else return true;
            }
        });
    });

    $('#poolingAllToEndUser').on('click', function () {
        $.msgBox({
            title: 'Pooling All Series',
            content: 'Only available series will be pooled',
            type: "prompt",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            inputContainerId: "destinationPools",
            beforeShow: function () {
                $("#destinationPools").html('');
                $("#destinationPools").append('<table>' + $("#endUserDesPools").val() + '</table>');
                $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool All series ?' + '</p>');
            },
            success: function (result) {
                if (result == "Yes") {
                    var pools = [];
                    $('input[name=checkedPools]:checked').each(function () {
                        pools.push($(this).attr("id"));
                    });
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
                                                    url: "/FreeSeries/PoolingSeries?" + url,
                                                    type: "POST",
                                                    data: { selectedPools: pools.toString(), selectedSeries: null, approvalType: "ENDUSER" },
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
                                })
                            }
                            else
                                return true;
                        }
                    })
                }
                else return true;
            }
        });
    });

    $('#exportSelectedSeries').on('click', function (e) {
        e.preventDefault();
        var seriesList = [];
        $('input[name=checkedSeries]:checked').each(function () {
            seriesList.push($(this).attr("value"));
        });
        var count = seriesList.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any serie",
                opacity: 0.0,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $(".hiddenInput").remove();
            $("#sampleForm").append("<input type = 'hidden' name='exortType' value='selected' class='hiddenInput' />");
            $("#sampleForm").append("<input type = 'hidden' name='selectedSeries' value='" + seriesList + "' class='hiddenInput'/>");
            $("#sampleForm").submit();
        }
    });

    $('#exportAllSeries').on('click', function (e) {
        e.preventDefault();
        var series = [];
        $('input[name=checkedSeries]').each(function () {
            series.push($(this).attr("value"));
        });
        var count = series.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "Series List Empty",
                opacity: 0.0,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $(".hiddenInput").remove();
            $("#sampleForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput' />");
            //$("#sampleForm").append("<input type = 'hidden' name='selectedSeries' value='" + series + "' class='hiddenInput'/>");
            $("#sampleForm").submit();
        }
    });
});