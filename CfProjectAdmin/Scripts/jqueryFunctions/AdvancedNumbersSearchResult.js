$(document).ready(function () {
    var numberType = $("input[name=numberType]").val();
    var searchType = $("input[name=searchType]").val();
    var numbersFromExcel = $("input[name=numbersFromExcel]").val();
    var url = "&searchType=" + searchType + "&numbersFromExcel=" + numbersFromExcel + "&";
    var moveLeft = 20;
    var moveDown = 10;
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        auto: false,
        url: "/Numbers/advancedNumbersSearchResultF?numberType=" + numberType + url,
    });

    $("#data-search").search({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/Numbers/advancedNumbersSearchResultF?numberType=" + numberType + url,
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/Numbers/advancedNumbersSearchResultF?numberType=" + numberType + url,
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
    $("#deleteAll").on('click', function (e) {
        e.preventDefault();
        var numbers = [];
        var status = [];
        var isSeries = [];
        $.msgBox({
            title: 'Delete Numbers ',
            content: 'Are You Sure you want to Delete All numbers?',
            type: "prompt",
            inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if ($("input[name=password]").val() == "")
                    $.msgBox({
                        title: 'WARNING',
                        content: "Error Password",
                        opacity: 0.5,
                        buttons: [{ value: "OK" }],
                        success: function (result) {
                            if (result == "OK")
                                location.reload();
                        }
                    })
                else {
                    if (result == "Yes") {
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Numbers/DeleteNumbers?advancedSearch=yes" + url,
                            type: "POST",
                            data: { numberType: numberType, selectedNumbersIds: numbers, selectedNumbersStatus: status, selctedNumbersIsSeries: isSeries },
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
    $('#deleteSelected').on('click', function () {
        var numbers = [];
        var status = [];
        var isSeries = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            numbers.push($(this).attr("id"));
            status.push($(this).attr("status"));
            isSeries.push($(this).attr("isSeries"));
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
                title: 'Delete Numbers',
                content: 'Are You Sure you want to delete ' + count + ' number(s)? ',
                type: "prompt",
                inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],

                success: function (result) {
                    var pass = $("input[name=password]").val();
                    if (pass == "")
                        $.msgBox({
                            title: 'WARNING',
                            content: "Error Password",
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                            success: function (result) {
                                if (result == "OK")
                                    location.reload();
                            }
                        })
                    else {
                        if (result == "Yes") {
                            $('body').addClass('wait');
                            $.ajax({
                                url: "/Numbers/DeleteNumbers",
                                type: "POST",
                                data: { numberType: numberType, selectedNumbersIds: numbers, selectedNumbersStatus: status, selctedNumbersIsSeries: isSeries },
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
    $("#activeSelected").on('click', function (e) {
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
                title: 'Active Numbers',
                content: 'Are You Sure you want to active ' + count + ' number(s)? ',
                type: "prompt",
                inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],

                success: function (result) {
                    var pass = $("input[name=password]").val();
                    if (pass == "")
                        $.msgBox({
                            title: 'WARNING',
                            content: "Error Password",
                            opacity: 0.5,
                            buttons: [{ value: "OK" }],
                            success: function (result) {
                                if (result == "OK")
                                    location.reload();
                            }
                        })
                    else {
                        if (result == "Yes") {
                            $('body').addClass('wait');
                            $.ajax({
                                url: "/Numbers/ActiveNumbers",
                                type: "POST",
                                data: { selectedNumbersIds: numbers },
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
    $("#activeAll").on('click', function (e) {
        e.preventDefault();
        var numbers = [];
        $.msgBox({
            title: 'Active Numbers ',
            content: 'Are You Sure you want to Active All numbers?',
            type: "prompt",
            inputs: [{ type: "password", name: "password", header: "Password", isDisabled: "" }],
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if ($("input[name=password]").val() == "")
                    $.msgBox({
                        title: 'WARNING',
                        content: "Error Password",
                        opacity: 0.5,
                        buttons: [{ value: "OK" }],
                        success: function (result) {
                            if (result == "OK")
                                location.reload();
                        }
                    })
                else {
                    if (result == "Yes") {
                        var numbers = [];
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Numbers/ActiveNumbers?advancedSearch=yes" + url,
                            type: "POST",
                            data: { selectedNumbersIds: numbers },
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
            $("#myForm").append("<input type = 'hidden' name='numberType' value='" + numberType + "' class='hiddenInput'/>");
            $("#myForm").submit();
        }
    });
    $('#exportAllNumbers').on('click', function (e) {
        e.preventDefault();
        $(".hiddenInput").remove();
        $("#myForm").append("<input type = 'hidden' name='exortType' value='all' class='hiddenInput' />");
        $("#myForm").append("<input type = 'hidden' name='numberType' value='" + numberType + "' class='hiddenInput'/>");
        $("#myForm").append("<input type = 'hidden' name='advancedSearch' value='yes' class='hiddenInput' />");
        $("#myForm").append("<input type = 'hidden' name='searchType' value='" + searchType + "' class='hiddenInput' />");
        $("#myForm").append("<input type = 'hidden' name='numbersFromExcel' value='"+ numbersFromExcel +"' class='hiddenInput' />");
        $("#myForm").submit();
    });
})