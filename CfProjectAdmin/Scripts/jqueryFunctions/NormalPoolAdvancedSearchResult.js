$(window).load(function () {
    var poolId = $("input[name=poolId]").val();
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
    $('.relatedPools').click(null, function (e) {
        var numberId = $(this).attr("number_Id");
        $.ajax({
            url: "/Pools/getrelatedNormalPools",
            type: "GET",
            data: { clickedNumber: numberId },
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
    $(document).on('contentChanged', function () {
        $('.relatedPools').click(null, function (e) {
            var numberId = $(this).attr("number_Id");
            $.ajax({
                url: "/Pools/getrelatedNormalPools",
                type: "GET",
                data: { clickedNumber: numberId },
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
    $('#removeSelectedNumbers').on('click', function () {
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
                success: function (result) {
                    if (result == "OK")
                        location.reload();
                }
            })
        }
        else {
            $.msgBox({
                title: 'Romove Numbers from ' + $('#removeSelectedNumbers').attr("name"),
                content: 'Are You Sure you want to remove ' + count + ' numbers from this pool',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        var numbers = [];
                        $('input[name=checkedNumbers]:checked').each(function () {
                            numbers.push($(this).attr("id"));
                        });
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Pools/RemoveSelectedNormalPoolNumbers",
                            type: "POST",
                            data: { poolId: poolId, selectedNumbers: numbers },
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
    $('#removeAllNumbers').on('click', function () {
        var numbers = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            numbers.push($(this).attr("id"));
        });        
        var count = numbers.length;        
            $.msgBox({
                title: 'Romove Numbers from ' + $('#removeAllNumbers').attr("name"),
                content: 'Are You Sure you want to remove all search result numbers from this pool',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Pools/RemoveSelectedNormalPoolNumbers",
                            type: "POST",
                            data: { poolId: poolId, selectedNumbers: numbers },
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
    $('#transferSelectedNumbers').on('click', function () {
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
                title: 'Transferring Numbers from  ' + $('#transferSelectedNumbers').attr("name"),
                type: "prompt",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                // inputs: [{ header: $('#reviewTextLBL').val() + ":", type: "textarea", name: "reviewText" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#desPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to transfer ' + count + ' numbers from this pool?' + '</p>');
                    $("#destinationPools").append('<p>' + '(trnsferred numbers will be removed from the pool)')
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
                                url: "/Pools/TransferSelectedNormalPoolNumbers",
                                type: "POST",
                                data: { poolId: poolId, selectedPools: pools, selectedNumbers: numbers },
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
    $('#transferAllNumbers').on('click', function () {
        var numbers = [];
        $('input[name=checkedNumbers]').each(function () {
            numbers.push($(this).attr("id"));
        });                     
            $.msgBox({
                title: 'Transferring Numbers from  ' + $('#transferAllNumbers').attr("name"),
                type: "prompt",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],                
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#desPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to transfer all search result numbers from this pool?' + '</p>');
                    $("#destinationPools").append('<p>' + '(trnsferred numbers will be removed from the pool)')
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
                                url: "/Pools/TransferSelectedNormalPoolNumbers",
                                type: "POST",
                                data: { poolId: poolId, selectedPools: pools, selectedNumbers: numbers },
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
    $('#exportSelectedNumbers').on('click', function () {
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
        var numbers = [];
        $('input[name=checkedNumbers]').each(function () {
            numbers.push($(this).attr("id"));
        });
        var count = numbers.length;       
            $(".hiddenInput").remove();
            $("#myForm").append("<input type = 'hidden' name='exortType' value='selected' class='hiddenInput' />");
            $("#myForm").append("<input type = 'hidden' name='selectedNumbers' value='" + numbers + "' class='hiddenInput'/>");
            $("#myForm").submit();
        
    });
});