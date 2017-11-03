$(window).load(function () {
    console.log(poolId);
    var moveLeft = 20;
    var moveDown = 10;
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
    $('#poolingSelectedNumbersToAdmin').on('click', function () {
        var numbers = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            numbers.push($(this).attr("id"));
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
                title: 'Pooling Numbers',
                content: 'Only available numbers will be pooled',
                type: "prompt",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#adminDesPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool ' + count + ' numbers ?' + '</p>');
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
                                url: "/FreeNumbers/PoolingNumbers",
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
        }
    });

    $('#poolingSelectedNumbersToEndUser').on('click', function () {
        var numbers = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            numbers.push($(this).attr("id"));
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
                title: 'Pooling Numbers',
                content: 'Only available numbers will be pooled',
                type: "prompt",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#endUserDesPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool ' + count + ' numbers ?' + '</p>');
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
                                url: "/FreeNumbers/PoolingNumbers",
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
        }
    });

    $('#poolingAllToAdmin').on('click', function () {
        var numbers = [];
        $('input[name=checkedNumbers]').each(function () {
            numbers.push($(this).attr("id"));
        });
            $.msgBox({
                title: 'Pooling Numbers',
                content: 'Only available numbers will be pooled',
                type: "prompt",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#adminDesPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool all search result numbers ?' + '</p>');
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
                                opacity: 0.5,
                                buttons: [{ value: "OK" }],
                            })
                        }
                        else {
                            $('body').addClass('wait');
                            $.ajax({
                                url: "/FreeNumbers/PoolingNumbers",
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
        var numbers = [];
        $('input[name=checkedNumbers]').each(function () {
            numbers.push($(this).attr("id"));
        });
            $.msgBox({
                title: 'Pooling Numbers',
                content: 'Only available numbers will be pooled',
                type: "prompt",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#endUserDesPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to Pool all search result numbers ?' + '</p>');
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
                                opacity: 0.5,
                                buttons: [{ value: "OK" }],
                            })
                        }
                        else {
                            $('body').addClass('wait');
                            $.ajax({
                                url: "/FreeNumbers/PoolingNumbers",
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

    $('#exportSelectedNumbers').on('click', function (e) {
        e.preventDefault();
        var numbers = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            numbers.push($(this).attr("id"));
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
            $(".hiddenInput").remove();
            $("#myForm").append("<input type = 'hidden' name='exortType' value='selected' class='hiddenInput' />");
            $("#myForm").append("<input type = 'hidden' name='selectedNumbers' value='" + numbers + "' class='hiddenInput'/>");
            $("#myForm").submit();
        }
    });
    $('#exportAllNumbers').on('click', function () {
        $(".hiddenInput").remove();
        var numbers = [];
        $('input[name=checkedNumbers]').each(function () {
            numbers.push($(this).attr("id"));
        });
        $("#myForm").append("<input type = 'hidden' name='exortType' value='selected' class='hiddenInput' />");
        $("#myForm").append("<input type = 'hidden' name='selectedNumbers' value='" + numbers + "' class='hiddenInput'/>");
        $("#myForm").submit();
    });
});