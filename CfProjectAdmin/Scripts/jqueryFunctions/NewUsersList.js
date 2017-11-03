$(document).ready(function () {
    $("#search-button").click(function () {
        location.href = "/MemberManagement/newUserList?search=" + $("#search").val();
    });
    $(".add-to-system").click(function (){
        var tds = $(this).closest('tr').find('td');
        var username = tds[0].innerText;
        var email = tds[1].innerText;
        location.href = "/MemberManagement/addNewRequester?username=" + username + "&email="+email;
    });
    $(".activate-user").click(function () {
        location.href = "/MemberManagement/activateRequester?requesterId=" + $(this).attr('reqId');
    });
    $(".deactivate-user").click(function () {
        location.href = "/MemberManagement/deactivateRequester?requesterId=" + $(this).attr('reqId');
    });
});