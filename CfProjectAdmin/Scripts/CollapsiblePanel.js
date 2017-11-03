/* 
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */


$(document).on('click', '.panel-heading span.clickable', function(e){
    speed = 1000;
    var $this = $(this);
	if(!$this.hasClass('panel-collapsed')) {
		$this.parents('.panel').find('.panel-body').slideUp(speed);
		$this.addClass('panel-collapsed');
		$this.find('i').removeClass('fa-chevron-up').addClass('fa-chevron-down');
	} else {
		$this.parents('.panel').find('.panel-body').slideDown(speed);
		$this.removeClass('panel-collapsed');
		$this.find('i').removeClass('fa-chevron-down').addClass('fa-chevron-up');
	}
})