$(window).load(function () {
    var poolId = $("input[name=poolId]").attr("value");
    var moveLeft = 20;
    var moveDown = 10;
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        auto: false,
        url: "/pools/getNormalPoolsDetailsNumbersListF?poolId="+poolId+"&",
    });

    $("#data-search").search({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/pools/getNormalPoolsDetailsNumbersListF?poolId=" + poolId+"&",
    });

    //$(document).on('click', '.sort_filter', function (e) {
    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/pools/getNormalPoolsDetailsNumbersListF?poolId=" + poolId+"&",
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
    $('.relatedPools').click(null, function (e) {
        var numberId = $(this).attr("number_Id");
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
                $('div#relatedPools_popUp').html('');
                if (data == null || data == "") {
                    $('div#relatedPools_popUp').show()
                                  .css('top', e.pageY + moveDown)
                                  .css('left', e.pageX + moveLeft)
                                  .append('No Pool')
                                  .appendTo('body');
                }
                else {
                    $('div#relatedPools_popUp').show()
                                     .css('top', e.pageY + moveDown)
                                     .css('left', e.pageX + moveLeft)
                                     .append('<table>' + data + '</table>')
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
    $(document).on('contentChanged', function () {        
        $('.relatedPools').click(null, function (e) {
            var numberId = $(this).attr("number_Id");
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
                    $('div#relatedPools_popUp').html('');
                    $('div#relatedPools_popUp').show()
                               .css('top', e.pageY + moveDown)
                               .css('left', e.pageX + moveLeft)
                               .append('<table>' + data + '</table>')
                               .appendTo('body');
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

    $('#removeAll').on('click', function () {        
        $.msgBox({
            title: 'Romove Numbers from ' + $('#removeAll').attr("name"),
            content: 'Are You Sure you want to remove All numbers from this pool',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/Pools/RemoveAllNormalPoolNumbers",
                        type: "POST",
                        data: { poolId: poolId },
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
                    $("#destinationPools").append('<p>' + '(transferred numbers will be removed from the pool)')
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
                        if ($('input[name=checkedPools]').length <= 0) {
                            $.msgBox({
                                title: 'WARNING',
                                content: "There isn't ant pool match the current Pool's Approval cycle - Classification-order",
                                opacity: 0.5,
                                buttons: [{ value: "OK" }],
                            })
                        } else {
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
                }
            });
        }
    });
 
    $('#transferAll').on('click', function () {        
        $.msgBox({
            title: 'Transferring Numbers from  ' + $('#transferAll').attr("name"),
            type: "prompt",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            // inputs: [{ header: $('#reviewTextLBL').val() + ":", type: "textarea", name: "reviewText" }],
            inputContainerId: "destinationPools",
            beforeShow: function () {
                $("#destinationPools").html('');
                $("#destinationPools").append('<table>' + $("#desPools").val() + '</table>');
                $("#destinationPools").append('<p>' + 'Are You Sure you want to transfer All numbers from this pool?' + '</p>');
                $("#destinationPools").append('<p>' + '(transferred numbers will be removed from the pool)')
            },
            success: function (result) {
                if (result == "Yes") {
                    var pools = [];
                    if ($('input[name=checkedPools]').length <= 0) {
                        $.msgBox({
                            title: 'WARNING',
                            content: "There isn't ant pool match the current Pool's Approval cycle - Classification-order",
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                        })
                    } else {
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
                                url: "/Pools/TransferAllNormalPoolNumbers",
                                type: "POST",
                                data: { poolId: poolId, selectedPools: pools },
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
        $(".hiddenInput").remove();        
        $("#myForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput'/>");
        $("#myForm").submit();
    });

});