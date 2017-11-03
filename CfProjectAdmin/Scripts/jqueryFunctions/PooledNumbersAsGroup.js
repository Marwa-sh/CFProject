$(document).ready(function () {
    var moveLeft = 20;
    var moveDown = 10;
    $().loadMore({
        button: $("#load-more"),
        container: $("#groups-container"),
        auto: false,
        url: "/FreeNumbers/getPooledNumbersAsGroupF?",
    });
    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/FreeNumbers/getPooledNumbersAsGroupF?",
    });
    $("input[name=groupByFilter]").filterek({
        button: $("#load-more"),
        container: $("#groups-container"),
        url: "/FreeNumbers/getPooledNumbersAsGroupF?",
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
    $('#releaseSelectedGroups').on('click', function () {
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
                title: 'release Groups',
                content: 'Are You Sure you want to release ' + count + ' group(s)?',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],              
                success: function (result) {
                    if (result == "Yes") {
                        $('body').addClass('wait');
                            $.ajax({
                                url: "/FreeNumbers/releaseGroups?" + appendedVarInUri,
                                type: "POST",
                                data: {selectedGroups: groups },
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
                })            
        }
    });
    $('#releaseAllNumbers').on('click', function () {
        var numbers = [];
        $.msgBox({
            title: 'Release Groups ',
            content: 'Are You Sure you want to release All groups?',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/FreeNumbers/ReleaseNumbers",
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
                        },
                        complete: function () {
                            $('body').removeClass('wait');
                        }
                    });
                }
            }
        });
    });
    $('#exportSelectedGroups').on('click', function (e) {
        e.preventDefault();
        var numbers = [];
        var appendedVarInUri = $(".filter_value").val();
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
            $("#myForm").append("<input type = 'hidden' name='groupFilterVal' value='" + appendedVarInUri + "'  class='hiddenInput'/>");
            $("#myForm").append("<input type = 'hidden' name='exortType' value='selected' class='hiddenInput' />");
            $("#myForm").append("<input type = 'hidden' name='selectedGroups' value='" + numbers + "' class='hiddenInput'/>");
            $("#myForm").submit();
        }
    });
    $('#exportAllGroups').on('click', function (e) {
        e.preventDefault();
        var appendedVarInUri = $(".filter_value").val();
        $(".hiddenInput").remove();
        $("#myForm").append("<input type = 'hidden' name='groupFilterVal' value='" + appendedVarInUri + "'  class='hiddenInput'/>");
        $("#myForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput' />");
        $("#myForm").submit();
    });
});