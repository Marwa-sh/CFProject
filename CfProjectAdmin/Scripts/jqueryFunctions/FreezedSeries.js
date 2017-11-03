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
        url: "/FreezedSeries/FreezedSeriesSearchResultF?" + url,
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#series-container"),
        url: "/FreezedSeries/FreezedSeriesSearchResultF?" + url,
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

    $(document).on('click', '#unfreezeSelectedSeries', function (e) {
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
        else
        {
            $.msgBox({
                title: 'Unfreeze Series',
                content: 'Are You Sure you want to unfreeze ' + count + ' serie(s)? ',
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
                                                    url: "/FreezedSeries/unfreezeSelectedSeries?" + url,
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
                                                                    content: "Unfreeze series have been failed",
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

    $(document).on('click', '#unfreezeAll', function (e) {
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
        else
        {
            $.msgBox({
                title: 'Unfreeze Series',
                content: 'Are You Sure you want to unfreeze all serie(s)? ',
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
                                                    url: "/FreezedSeries/unfreezeAllSeries?"+url,
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
                                                                    content: "Unfreeze series have been failed",
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
        else
        {
            $('#sampleForm').append("<input type = 'hidden' name='exortType' value='all' />");
            $('#sampleForm').submit();
        }        
    });

});