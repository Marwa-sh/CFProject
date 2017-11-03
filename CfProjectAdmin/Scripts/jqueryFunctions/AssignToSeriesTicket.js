$(document).ready(function () {
    $(document).on('click', '.assign-to-ticket', function () {
        var tabIndex = $(this).attr('tab-index');
        location.href = '/AxiosSeries/ticketFieldDetails?ticketId=' + $("#ticketId").val() +
                '&tab-index=' + tabIndex + "&ticketMetadataId=" +
                $("#ticketMetadataId").val() + "&serviceOfferingName=" + $("#serviceOfferingName").val() +
                "&requestedCustomerId=" + $("requestedCustomerId").val() + "&requestedIdType=" + $("#requestedIdType").val()
                + "&requestedContractNumber=" + $("#requestedContractNumber").val()
                ;
    });
    

});