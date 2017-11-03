$(document).ready(function () {
    $("#Reserve").attr("disabled", true);
    var requestedNumber = $("#requestedNumberCount").val();
    $(document).on('click', ':checkbox', function () {
        $('input:checkbox').removeAttr('checked');
        var parent = $(this).closest('tr');
        allNextSiblings = parent.nextAll();
        if (allNextSiblings.length >= requestedNumber -1) {
            this.checked = true;
            var counter = 1;
            $.each(allNextSiblings, function () {
                if (counter == requestedNumber) {
                    return false;
                }
                $(this).find('.checked-number').each(function () {
                    this.checked = true;
                });
                counter++;
            });
        }
        if ($("input:checkbox:checked").length > 0) {
            $("#Reserve").attr("disabled", false);
        } else {
            $("#Reserve").attr("disabled", true);
        }
    });
});