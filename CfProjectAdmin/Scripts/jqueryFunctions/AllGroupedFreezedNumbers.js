$(window).load(function () {
    var groupFilter = $("input[name=groupFilter]").val();
    var groupType = $("input[name=groupType]").val();

    var url = "groupFilter=" + groupFilter + "&groupType=" + groupType + "&matchType=" + $("#matchType").val()
               + "&matchText=" + $("#matchText").val() + "&matchAllAny=" + $("#matchAllAny").val()
               + "&rangeString=" + $("#rangeString").val() + "&classificationString=" + $("#classificationString").val()
               + "&statusString=" + $("#statusString").val() + "&isUsedBefore=" + $("#isUsedBefore").val()
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
        url: "/FreezedNumbers/getAllGroupedFreezedNumbersF?" + url,
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreezedNumbers/getAllGroupedFreezedNumbersF?" + url,
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
        }
        else
        {
            $('#sampleForm').append("<input type = 'hidden' name='exortType' value='all' />");
            $('#sampleForm').submit();
        }        
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
});