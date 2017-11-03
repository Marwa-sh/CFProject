$(document).ready(function () {
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
    })
});