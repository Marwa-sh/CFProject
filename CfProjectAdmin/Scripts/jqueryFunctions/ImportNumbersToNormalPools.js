$(document).ready(function () {
    var moveLeft = 20;
    var moveDown = 10;
    var poolId = $("input[name=poolId]").val();
    
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
                }
            });
        });
        $(document).click(null, function () {
            $('div#relatedPools_popUp').html('');
            $('div#relatedPools_popUp').hide();
        });

    });
    $(document).on('click', '.getUnmatched', function (e) {
        e.preventDefault();   
        $('div#unmatched_popUp').show()
            .css('top', e.pageY + moveDown)
            .css('left', e.pageX + moveLeft)
            .appendTo('body');
    });
    $(document).click(null, function (e) {
        if (!$(e.target).parents().andSelf().is('.getUnmatched')) {
            $('div#unmatched_popUp').hide();
        }
    });
    $(document).on('click', '.sort_groups_checkbox', function (e) {
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
    $(document).on('click', "input[name=groupByFilter]", function (e) {
        e.preventDefault();
        $(".hiddenInput").remove();
        var groupFilter = $("input[name=groupByFilter]:checked").val();
        $("#myForm").append("<input type = 'hidden' name='groupFilter' value='" + groupFilter + "'  class='hiddenInput'/>");
        $("#myForm").append("<input type='hidden' name='GroupingJS' value='GroupingJS' class='hiddenInput'/>");
        $("#myForm").submit();
    });
    $(document).on('click', '.sort_filter', function (e) {
        e.preventDefault();
        $(".hiddenInput").remove();
        var sortFilter = $(this).attr('name');
        $("#myForm").append("<input type='hidden' name='sortNumbers' value='" + sortFilter + "' class='hiddenInput' />");
        $("#myForm").submit();
    });
    $(document).on('click', '.grouping_sort_filter', function (e) {
        e.preventDefault();
        $(".hiddenInput").remove();
        var sortFilter = $(this).attr('name');
        var groupFilter = $("input[name=groupByFilter]:checked").val();
        $("#myForm").append("<input type='hidden' name='sortGroups' value='" + sortFilter + "' class='hiddenInput' />");
        $("#myForm").append("<input type = 'hidden' name='groupFilter' value='" + groupFilter + "'  class='hiddenInput'/>");
        $("#myForm").append("<input type='hidden' name='GroupingJS' value='GroupingJS' class='hiddenInput'/>");
        $("#myForm").submit();
    });
    $('#importSelectedNumbers').on('click', function (e) {
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
            success: function (result) {
                if (result == "OK")
                    location.reload();
            }
        })
    }
    else {
        $.msgBox({
            title: 'Add Numbers',
            content: 'Are You Sure you want to add ' + count + ' number(s)? ',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {                       
                    $.ajax({
                        url: "/Pools/NormalPoolAddNumbers?poolId=" + poolId,
                        type: "POST",
                        data: { selectedNumbers: numbers },
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
                        }
                    });
                }
            }
        });
    }
    });
    $("#importAll").on('click', function (e) {
        e.preventDefault();
        var numbers = $("input[name=numIds]").val();
        var numIds = numbers.split(',');
        $.msgBox({
            title: 'Add Numbers',
            content: 'Are You Sure you want to add all numbers ? ',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    $.ajax({
                        url: "/Pools/NormalPoolAddNumbers?poolId=" + poolId,
                        type: "POST",
                        data: { selectedNumbers: numIds },
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
                        }
                    });
                }
            }
        });
    });
    $("#importSelectedGroups").on('click', function (e) {
        e.preventDefault();
        var groupFilter = $("input[name=filter]").val();
        var groups = [];
        var numbers = $("input[name=numIds]").val();
        var numIds = numbers.split(',');
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
                title: 'Add Numbers',
                content: 'Are You Sure you want to add ' + count + ' group(s)? ',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        $.ajax({
                            url: "/Pools/addSelectedGroupsToNormalPool?poolId=" + poolId + "&groupByFilter="+ groupFilter,
                            type: "POST",
                            data: { selectedGroups: groups, sourceNumId: numIds },
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
                            }
                        });
                    }
                }
            });
        }
    })
});
