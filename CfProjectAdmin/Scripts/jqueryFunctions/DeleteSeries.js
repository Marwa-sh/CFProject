//$(document).ready(function () {
//    var moveLeft = -50;
//    var moveDown = -40;
//    $(document).on('click', '#edit_series', function (e) {
//        e.preventDefault();
//        var seriesId = $('#edit_series').attr('series');
//        $('div#edit_series').html('');
//        $('div#edit_series').toggle();
//        //$('div#pool_option').css('top', e.pageY + moveDown);
//        //$('div#pool_option').css('left', e.pageX + moveLeft);
//        $('div#edit_series ').append('<table>'
//                        + "<tr><td><a href='/SeriesManagement/editSeries?seriesId=" + serieslId + "&type=SERIES'>" + "Edit Series Info" + "</a></td></tr>"
//                        + "<tr><td><a href='#' id='delete' seriesId='" + serieslId + "'>" + "Delete Series" + "</a></td></tr>"
//                        + '</table>');
//    });
$(document).ready(function () {
    var moveLeft = -50;
    var moveDown = -40;
    $(document).on('click', '#edit_pool', function (e) {
        e.preventDefault();
        var serieID = $('#edit_pool').attr('serieid');
       // $('div#pool_option').html('');
        $('div#pool_option').toggle(); 
        //$('div#pool_option').css('top', e.pageY + moveDown);
        //$('div#pool_option').css('left', e.pageX + moveLeft);
        $('div#pool_option').html('<table>'
                        + "<tr><td><a href='/SeriesManagement/FragmentSeries?serieID=" + serieID + "&type=NORMAL'>" + "Fragment Series" + "</a></td></tr>"
                        + "<tr><td><a href='#' id='delete' serieID='" + serieID + "'>" + "Delete Series" + "</a></td></tr>"
                        + '</table>');
    });
    $(document).on('click', '#delete', function (e) {
        e.preventDefault();
        var serieID = $('#delete').attr('serieID');
        $.msgBox({
            title: 'Delete Pool ',
            content: 'Are You Sure you want to delete this Series',
            type: "confirm",
            opacity: 0.5,
            buttons: [{ value: "Yes" }, { value: "No" }],
            success: function (result) {
                if (result == "Yes") {
                    $('body').addClass('wait');
                    $.ajax({
                        url: "/SeriesManagement/deleteSeries",
                        type: "POST",
                        data: { serieID: serieID },
                        dataType: "json",
                        traditional: true,
                        cache: false,
                        async: true,
                        success:
                            function (json) {
                                $.msgBox({
                                    title: 'success msg',
                                    content: json,
                                    type: "success",
                                    opacity: 0.5,
                                    buttons: [{ value: "OK" }],
                                    success: function (result) {
                                        if (result == "OK")
                                            location.href = "/SeriesManagement/SeriesDetails";
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
});