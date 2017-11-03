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
        url: "/FreezedSeries/UNfreezedSeriesSearchResultF?" + url,
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#series-container"),
        url: "/FreezedSeries/UNfreezedSeriesSearchResultF?" + url,
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

    $(document).on('click', '#freezeSelectedSeries', function (e) {
        e.preventDefault();
        var selectedSeries = [];
        $("input[name='checkedSeries']:checked").each(function () {
            selectedSeries.push(this.value);
        });
        var count = selectedSeries.length;
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
                title: 'Freeze Series',
                content: 'Are You Sure you want to freeze ' + count + ' serie(s)? ',
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
                                                    url: "/FreezedSeries/freezeSelectedSeries?" + url,
                                                    type: "GET",
                                                    data: { seriesID: selectedSeries.toString() },
                                                    dataType: "json",
                                                    traditional: true,
                                                    cache: false,
                                                    async: true,
                                                    success:
                                                        function (data) {
                                                            if (data.status) {
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
                                                            }
                                                            else {
                                                                $.msgBox({
                                                                    title: 'WARNING',
                                                                    content: "Freeze series have been failed",
                                                                    opacity: 0.5,
                                                                    buttons: [{ value: "OK" }],
                                                                })
                                                            }
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

    $(document).on('click', '#freezeAllSeries', function (e) {
        e.preventDefault();
        var series = [];
        $("input[name='checkedSeries']").each(function () {
            series.push(this.value);
        });
        var count = series.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "Series List Empty",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Freeze Series',
                content: 'Are You Sure you want to freeze all serie(s)? ',
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
                                                            if (data.status) {
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
                                                            }
                                                            else {
                                                                $.msgBox({
                                                                    title: 'WARNING',
                                                                    content: "Freeze series have been failed",
                                                                    opacity: 0.5,
                                                                    buttons: [{ value: "OK" }],
                                                                })
                                                            }
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
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $('#sampleForm').append("<input type = 'hidden' name='exortType' value='selected' />");
            $('#sampleForm').append("<input type = 'hidden' name='selectedSeries' value='" + seriesList + "'/>");
            $('#sampleForm').submit();
        }
    });

    $('#exportAllSeries').on('click', function (e) {
        e.preventDefault();
        var Series = [];
        $("input[name='checkedSeries']").each(function () {
            Series.push(this.value);
        });
        if (Series.length == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "Series List Empty",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $('#sampleForm').append("<input type = 'hidden' name='exortType' value='all' />");
            $('#sampleForm').submit();
        }       
    });

    $(document).on('click', '.relatedPools', function (e) {
        var serieId = $(this).attr("serie_id");
        $.ajax({
            url: "/Pools/getrelatedSeriesPools",
            type: "GET",
            data: { clickedSeries: serieId },
            dataType: "json",
            traditional: true,
            cache: false,
            async: true,
            success: function (data) {
                if (data.length != 0) {
                    $('div#relatedPools_popUp').html('');
                    $('div#relatedPools_popUp').show()
                                      .css('top', e.pageY + moveDown)
                                      .css('left', e.pageX + moveLeft)
                                      .append('<table>' + data + '</table>')
                                      .appendTo('body');
                }
                else {
                    $('div#relatedPools_popUp').html('');
                    $('div#relatedPools_popUp').show()
                          .css('top', e.pageY + moveDown)
                          .css('left', e.pageX + moveLeft)
                          .append('<table>No Pools</table>')
                          .appendTo('body');
                }
            },
            error: function (data) {
            }
        });
    });

    $(document).click(null, function () {
        $('div#relatedPools_popUp').html('');
        $('div#relatedPools_popUp').hide();
    });
});