$(document).ready(function () {
    var url = "/FreeNumbers/pooledNumberSearchResultF?matchType=" + $("#matchType").val()
                + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
                + "&rangeString=" + $("#range").val() + "&classificationString=" + $("#classification").val()
                + "&poolsString=" + $("#pools").val()
                + "&statusString=" + $("#status").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
                + "&relatedPoolsOperator=" + $("#relatedPoolsOperator").val() + "&relatedPoolsValue=" + $("#relatedPoolsValue").val()
                + "&numberPriceOperator=" + $("#numberPriceOperator").val() + "&numberPriceValue=" + $("#numberPriceValue").val()
                + "&totalScoreOperator=" + $("#totalScoreOperator").val() +
                "&totalScoreValue=" + $("#totalScoreValue").val()
                + "&avScoreOperator=" + $("#avScoreOperator").val() +
                "&avScoreValue=" + $("#avScoreValue").val()
                + "&";
    var urlForFunctions = "?fromSearch=YES"
                + "&matchType=" + $("#matchType").val()                
                + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
                + "&rangeString=" + $("#range").val() + "&classificationString=" + $("#classification").val()
                + "&poolsString=" + $("#pools").val()
                + "&statusString=" + $("#status").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
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
        url: url,
    });

    $("#data-search").search({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: url,
    });
    //$(document).on('click', '.sort_filter', function (e) {
    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: url,
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
    $('#releaseSelectedNumbers').on('click', function () {
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
                title: 'Release Numbers',
                content: 'Are You Sure you want to release ' + count + ' number(s)? ',
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
        }
    });

    $('#releaseAllNumbers').on('click', function () {
        $.msgBox({
            title: 'Release Numbers ',
            content: 'Are You Sure you want to release All numbers?',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    var numbers = [];
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/FreeNumbers/ReleaseNumbers" + urlForFunctions,
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
    $('#exportAllNumbers').on('click', function (e) {
        e.preventDefault();
        $(".hiddenInput").remove();
        $("#myForm").append("<input type = 'hidden' name='fromSearch' value='YES' class='hiddenInput' />");       
        $("#myForm").submit();
    });
});