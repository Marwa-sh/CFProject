$(document).ready(function () {
    $().loadMore({
        button: $("#load-more"),
        container: $("#series-container"),
        auto: false,
        url: "/Series/DetectSeriesF?",
    });
    $('#addSelected').click(function (e) {
        $('body').addClass('wait');
        e.preventDefault();        
        var series = [];
        $('input[name=checkedNumbers]:checked').each(function () {
            series.push($(this).attr("id"));
        });
        var count = series.length;
        if (count == 0) {
            $.msgBox({
                title: 'WARNING',
                content: "You didn't select any series",
                opacity: 0.5,
                buttons: [{ value: "OK" }],
            })
        }
        else {
            $.msgBox({
                title: 'Add Series',
                content: 'Are You Sure you want to add ' + count + ' series? ',
                type: "confirm",
                opacity: 0.5,
                buttons: [{ value: "Yes" }, { value: "No" }],
                success: function (result) {
                    if (result == "Yes") {
                        $('body').addClass('wait');
                        $.ajax({
                            url: "/Series/AddDetectedSeriesToNMS",
                            type: "POST",
                            data: { selectedSeries: series },
                            dataType: "json",
                            traditional: true,
                            cache: false,
                            async: true,
                            success: function (data) {
                                $('body').removeClass('wait');
                                $.msgBox({
                                    title: 'success',
                                    content: data,
                                    type: "success",
                                    opacity: 0.5,
                                    buttons: [{ value: "OK" }],
                                    success: function (result) {
                                        if (result == "OK") {
                                            if (result == 'an error occurred'){
                                                return true;

                                            }
                                            else {
                                                location.href = "/Series/seriesList"
                                            }
                                        }

                                    }
                                });
                            }

                        });
                    }
                }
            });
        }
    });
    $(document).on('click', '#select_all', function () {
        if (this.checked) {
            // Iterate each checkbox
            $(':checkbox').each(function () {
                this.checked = true;
            });
        }
        else {
            $(':checkbox').each(function () {
                this.checked = false;
            });

        }
    });
})