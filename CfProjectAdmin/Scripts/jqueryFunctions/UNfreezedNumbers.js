$(window).load(function () {
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

    var moveLeft = 20;
    var moveDown = 10;
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        auto: false,
        url: "/FreezedNumbers/UNFreezedNumberSearchResultF?" + url,
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreezedNumbers/UNFreezedNumberSearchResultF?" + url,
    });

    $("#data-search").search({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreezedNumbers/UNFreezedNumberSearchResultF?" + url,
    });

    $(document).on('click', '#sort_checkbox', function (e) {
        e.preventDefault();
        var checkedRows = $(".checked-number:checked").closest("tr");
        var cloneCheckedRows = checkedRows.clone();
        var uncheckedRows = $(".checked-number:not(:checked)").closest("tr");
        var cloneUncheckedRows = uncheckedRows.clone();
        var header = $("#numbers-container tr").first().clone();
        $("#numbers-container").html("");
        $("#numbers-container").append(header);
        cloneCheckedRows.each(function () {
            $("#numbers-container").append($(this));
        });
        cloneUncheckedRows.each(function () {
            $("#numbers-container").append($(this));
        });
    });

    $(document).on('click', '#freezeSelectedNumbers', function (e) {
        e.preventDefault();
        var selectedNumbers = [];
        $("input[name='checkedNumbers']:checked").each(function () {
            selectedNumbers.push(this.value);
        });
        var count = selectedNumbers.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any number",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Freeze Numbers',
                content: 'Are You Sure you want to freeze ' + count + ' number(s)? ',
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
                                                    url: "/FreezedNumbers/freezeSelectedNumbers",
                                                    type: "GET",
                                                    data: { numberID: selectedNumbers.toString() },
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
                                                            else {
                                                                $.msgBox({
                                                                    title: 'WARNING',
                                                                    content: "Freeze numbers have been failed",
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

    $(document).on('click', '#freezeAllNumbers', function (e) {
        e.preventDefault();
        var numbers = [];
        var searchParam = "matchType=" + $("#matchType").val() + "&matchText=" + $("#matchText").val()
        + "&matchAllAny=" + $("#matchAllAny").val() + "&rangeString=" + $("#rangeString").val() + "&classificationString=" + $("#classificationString").val()
        + "&statusString=" + $("#statusString").val() + "&poolsString=" + $("#poolsString").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
        + "&numberPriceOperator=" + $("#numberPriceOperator").val() +
        "&numberPriceValue=" + $("#numberPriceValue").val();
        ;
        $("input[name='checkedNumbers']").each(function () {
            numbers.push(this.value);
        });
        var count = numbers.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any number",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Freeze Numbers',
                content: 'Are You Sure you want to freeze all numbers? ',
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
                                                    url: "/FreezedNumbers/freezeAllNumbers?" + searchParam,
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
                                                                    content: "Freeze numbers have been failed",
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


    $('#exportSelectedNumbers').on('click', function (e) {
        e.preventDefault();
        var numbersList = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            numbersList.push($(this).attr("value"));
        });
        var count = numbersList.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any number",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $('#sampleForm').find('input[name=exortType]').remove();
            $('#sampleForm').find('input[name=selectedNumbers]').remove();
            $('#sampleForm').append("<input type = 'hidden' name='exortType' value='selected' />");
            $('#sampleForm').append("<input type = 'hidden' name='selectedNumbers' value='" + numbersList + "'/>");
            $('#sampleForm').submit();
        }
    });

    $('#exportAllNumbers').on('click', function (e) {
        e.preventDefault();
        var numbersList = [];
        $('input[name=checkedNumbers]').each(function () {
            numbersList.push($(this).attr("value"));
        });
        var count = numbersList.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "Numbers List Empty",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        } else {
            $('#sampleForm').find('input[name=exortType]').remove();
            $('#sampleForm').append("<input type = 'hidden' name='exortType' value='all' />");
            $('#sampleForm').submit();
        }
    });

    $(document).on('click', '.relatedPools', function (e) {
        e.preventDefault();
        var numberId = $(this).attr("number_id");
        $('body').addClass('wait');
        $.ajax({
            url: "/Pools/getrelatedNormalPools",
            type: "GET",
            data: { clickedNumber: numberId },
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
            },
            complete: function () {
                $('body').removeClass('wait');
            }
        });
    });
    $(document).click(null, function () {
        $('div#relatedPools_popUp').html('');
        $('div#relatedPools_popUp').hide();
    });
});