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
        url: "/FreeSeries/PooledSeriesSearchResultF?" + url,
    });
    
    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#series-container"),
        url: "/FreeSeries/PooledSeriesSearchResultF?" + url,
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

    $('#releaseSelectedSeries').on('click', function () {
        var series = [];
        $('input[name=checkedSeries]:checked').each(function () {
            series.push($(this).attr("value"));
        });
        var count = series.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any serie",
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
                title: 'Release Series',
                content: 'Are You Sure you want to release ' + count + ' serie(s)? ',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        var series = [];
                        $('input[name=checkedSeries]:checked').each(function () {
                            series.push($(this).attr("value"));
                        });
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/FreeSeries/ReleaseSeries?"+ url,
                            type: "POST",
                            data: { selectedSeries: series.toString() },
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
        }
    });

    $('#releaseAllSeries').on('click', function () {
        $.msgBox({
            title: 'Release Series ',
            content: 'Are You Sure you want to release All series?',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    var series = [];
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/FreeSeries/ReleaseSeries?" + url,
                        type: "POST",
                        data: { selectedSeries: series.toString() },
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

    $('#exportSelectedSeries').on('click', function (e) {
        e.preventDefault();
        var series = [];
        $('input[name=checkedSeries]:checked').each(function () {
            series.push($(this).attr("value"));
        });
        var count = series.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any serie",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $(".hiddenInput").remove();
            $("#sampleForm").append("<input type = 'hidden' name='exortType' value='selected' class='hiddenInput' />");
            $("#sampleForm").append("<input type = 'hidden' name='selectedSeries' value='" + series + "' class='hiddenInput'/>");
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
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        $(".hiddenInput").remove();
        $("#sampleForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput' />");
        //$("#sampleForm").append("<input type = 'hidden' name='selectedSeries' value='" + series + "' class='hiddenInput'/>");
        $("#sampleForm").submit();
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
                $('div#relatedPools_popUp').html('');
                $('div#relatedPools_popUp').show()
                                  .css('top', e.pageY + moveDown)
                                  .css('left', e.pageX + moveLeft)
                                  .append('<table>' + data + '</table>')
                                  .appendTo('body');
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