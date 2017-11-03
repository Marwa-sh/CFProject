$(window).load(function () {

    $().loadMore({
        button: $("#load-more"),
        container: $("#reservation-container"),
        url: "/CorporateReservation/MyReservationF?",
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#reservation-container"),
        url: "/CorporateReservation/MyReservationF?",
    });

    $("#data-search").search({
        button: $("#load-more"),
        container: $("#reservation-container"),
        url: "/CorporateReservation/MyReservationF?",
    });

});