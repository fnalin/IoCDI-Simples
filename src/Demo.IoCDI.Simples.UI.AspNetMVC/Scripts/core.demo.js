/*
	By Fabiano Nalin - @2014 - Maio
	FabianoNalin.net.br
*/
$(document).ajaxSend(function (event, request, settings) {
	$('#waitModal').modal('show');
});

$(document).ajaxComplete(function (event, request, settings) {
	$('#waitModal').modal('hide');
});