
$(document).ready(function () {
    if ($($('.checkbox.meal input')[0]).prop('checked') == true) {
        $('.starter-dropdown').prop('disabled', false).removeClass('disabled').addClass('enabled');
        $('.main-dropdown').prop('disabled', false).removeClass('disabled').addClass('enabled');
        $('.dessert-dropdown').prop('disabled', false).removeClass('disabled').addClass('enabled');
    } else {
        $('.starter-dropdown').prop('disabled', true).removeClass('enabled').addClass('disabled');
        $('.main-dropdown').prop('disabled', true).removeClass('enabled').addClass('disabled');
        $('.dessert-dropdown').prop('disabled', true).removeClass('enabled').addClass('disabled');
    }

    $('.checkbox.meal input').click(function () {
        if ($(this).prop('checked') == true) {
            $('.starter-dropdown').prop('disabled', false).removeClass('disabled').addClass('enabled');
            $('.main-dropdown').prop('disabled', false).removeClass('disabled').addClass('enabled');
            $('.dessert-dropdown').prop('disabled', false).removeClass('disabled').addClass('enabled');
        } else {
            $('.starter-dropdown').prop('disabled', true).removeClass('enabled').addClass('disabled');
            $('.main-dropdown').prop('disabled', true).removeClass('enabled').addClass('disabled');
            $('.dessert-dropdown').prop('disabled', true).removeClass('enabled').addClass('disabled');
        }
    });
})