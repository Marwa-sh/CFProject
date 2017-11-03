$(window).load(function () {
    var moveLeft = 20;
    var moveDown = 10;
    var serieID = $("input[name=serieID]").attr("value");
    $().loadMore({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreezedSeries/getSerieDetailsF?serieID=" + serieID + "&",
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreezedSeries/getSerieDetailsF?serieID=" + serieID + "&",
    });

    $("#data-search").search({
        button: $("#load-more"),
        container: $("#numbers-container"),
        url: "/FreezedSeries/getSerieDetailsF?serieID=" + serieID + "&",
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
    

    $('#exportAllNumbers').on('click', function (e) {
        e.preventDefault();
        $('#sampleForm').submit();
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