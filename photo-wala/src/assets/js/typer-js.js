<script type="text/javascript">
	var win = $(window),
		foo = $('#typer');

	foo.typer(['Creative photography', 'Modern photography ', 'Classic photography ']);

	// unneeded...
	win.resize(function(){
		var fontSize = Math.max(Math.min(win.width() / (1 * 10), parseFloat(Number.POSITIVE_INFINITY)), parseFloat(Number.NEGATIVE_INFINITY));

		foo.css({
			fontSize: fontSize * .8 + 'px'
		});
	}).resize();
</script>
<script type="text/javascript">
	jQuery(document).ready(function($) {
		$(".scroll").click(function(event){		
			event.preventDefault();
			$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
		});
	});
</script> 