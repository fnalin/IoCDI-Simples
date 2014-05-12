/*
	By Fabiano Nalin - @2014 - Maio
	FabianoNalin.net.br
*/
$(document).ready(function () {
    CarregaDados($("#tipoTecDDL").val());
});

$("#tipoTecDDL").on('change', function () {
    CarregaDados($(this).val());
});

var CarregaDados = function (id) {
    var strUrl = "/Home/Get/" + id;
    $.ajax(
	{
	    type: 'GET',
	    url: strUrl,
	    dataType: 'html',
	    cache: false,
	    async: true,
	    success: function (data) {
	        $('#ListagemProd').html(data);
	    },
	    error: function () {
	        $("#ListagemProd").html("<div id='erro-mensagem'><p style='color:gray;'><small><em><strong>Erro.<br />Não foi possível recuperar os dados do servidor!</strong></em></small></p></div>");
	    },
	});
};