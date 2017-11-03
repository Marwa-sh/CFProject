$(window).load(function () {
    
    $().loadMore({
        button: $("#load-more"),
        container: $("#reservation-container"),
        url: "/VIPReservation/MyReservationF?",
    });

    $('.sort_filter').sortt({
        button: $("#load-more"),
        container: $("#reservation-container"),
        url: "/VIPReservation/MyReservationF?",
    });

    $("#data-search").search({
        button: $("#load-more"),
        container: $("#reservation-container"),
        url: "/VIPReservation/MyReservationF?",
    });

});