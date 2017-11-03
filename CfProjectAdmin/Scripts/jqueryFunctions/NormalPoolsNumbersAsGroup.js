$(window).load(function () {    
    var poolId = $('input[name=poolId]').attr("value");
    $().loadMore({
        button: $("#load-more"),
        container: $("#groups-container"),
        auto: false,
        url: "/Pools/getNormalPoolNumbersAsGroupF?poolId=" + poolId+"&",
    });
    $("input[name=groupByFilter]").filterek({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/Pools/getNormalPoolNumbersAsGroupF?poolId=" + poolId + "&",
    });
    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/Pools/getNormalPoolNumbersAsGroupF?poolId=" + poolId + "&",
    });
    $(document).on('click', '.sort_checkbox', function (e) {
        e.preventDefault();
        var checkedRows = $(".checked-number:checked").closest("tr");
        var cloneCheckedRows = checkedRows.clone();
        var uncheckedRows = $(".checked-number:not(:checked)").closest("tr");
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
    $('#removeSelectedGroups').on('click', function () {
        var groups = [];
        var appendedVarInUri = $(".filter_value").val();
        $('input[name=checkedNumbers]:checked').each(function () {
            groups.push($(this).attr("id"));
        });
        var count = groups.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any group",
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
                title: 'Romove Numbers groups from ' + $('#removeSelectedGroups').attr("name"),
                content: 'Are You Sure you want to remove ' + count + ' groups from this pool',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        var groups = [];
                        $('input[name=checkedNumbers]:checked').each(function () {
                            groups.push($(this).attr("id"));
                        });
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Pools/removeSelectedNormalPoolGroups?" + appendedVarInUri,
                            type: "POST",
                            data: { poolId: poolId, selectedGroups: groups },
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
        var appendedVarInUri = $(".filter_value").val();
        $.msgBox({
            title: 'Romove Numbers groups from ' + $('#removeAll').attr("name"),
            content: 'Are You Sure you want to remove All numbers from this pool',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/Pools/RemoveAllNormalPoolNumbers?" + appendedVarInUri,
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
    $('#transferSelectedGroups').on('click', function () {        
        var groups = [];
        var appendedVarInUri = $(".filter_value").val();
        $('input[name=checkedNumbers]:checked').each(function () {
            groups.push($(this).attr("id"));
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
            $.msgBox({
                title: 'Transferring numbers groups from  ' + $('#transferSelectedGroups').attr("name"),
                type: "prompt",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                // inputs: [{ header: $('#reviewTextLBL').val() + ":", type: "textarea", name: "reviewText" }],
                inputContainerId: "destinationPools",
                beforeShow: function () {
                    $("#destinationPools").html('');
                    $("#destinationPools").append('<table>' + $("#desPools").val() + '</table>');
                    $("#destinationPools").append('<p>' + 'Are You Sure you want to transfer ' + count + ' groups from this pool?' + '</p>');
                    $("#destinationPools").append('<p>' + '(trnsferred groups will be removed from the pool)')
                },
                success: function (result) {
                    if (result == "Yes") {
                    //    var numbers = [];
                    //    $('input[name=checkedNumbers]:checked').each(function () {
                    //        numbers.push($(this).attr("id"));
                    //    });
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
                                url: "/Pools/transferSelectedNormalPoolGroups?" + appendedVarInUri,
                                type: "POST",
                                data: { poolId: poolId, selectedPools: pools, selectedGroups: groups },
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
    $('#transferAll').on('click', function () {
        var appendedVarInUri = $(".filter_value").val();
        $.msgBox({
            title: 'Transferring Numbers groups from  ' + $('#transferAll').attr("name"),
            type: "prompt",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            // inputs: [{ header: $('#reviewTextLBL').val() + ":", type: "textarea", name: "reviewText" }],
            inputContainerId: "destinationPools",
            beforeShow: function () {
                $("#destinationPools").html('');
                $("#destinationPools").append('<table>' + $("#desPools").val() + '</table>');
                $("#destinationPools").append('<p>' + 'Are You Sure you want to transfer All numbers from this pool?' + '</p>');
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
                            url: "/Pools/TransferAllNormalPoolNumbers?" + appendedVarInUri,
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
        });
    });
    $('#exportSelectedGroups').on('click', function () {
        var groups = [];
        var appendedVarInUri = $(".filter_value").val();
        $('input[name=checkedNumbers]:checked').each(function () {
            groups.push($(this).attr("id"));
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
            $("#myForm").append("<input type = 'hidden' name='groupFilterVal' value='" + appendedVarInUri + "'  class='hiddenInput'/>");
            $("#myForm").append("<input type = 'hidden' name='exortType' value='selected'  class='hiddenInput'/>");
            $("#myForm").append("<input type = 'hidden' name='selectedGroups' value='" + groups + "' class='hiddenInput' />");
            $("#myForm").submit();
        }
    });
    $('#exportAllGroups').on('click', function () {
        var appendedVarInUri = $(".filter_value").val();
        $(".hiddenInput").remove();
        $("#myForm").append("<input type = 'hidden' name='groupFilterVal' value='" + appendedVarInUri + "'  class='hiddenInput'/>");
        $("#myForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput' />");
        $("#myForm").submit();
    });
});