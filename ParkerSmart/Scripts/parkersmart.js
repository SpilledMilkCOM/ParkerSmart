$(function () {

	// ----==== MOBILE ====----
	// This must be in place to resize for mobile (mostly)

	$(window).on("load resize", function () {
		$(".fill-screen").css("height", window.innerHeight);
	});

	// ----==== TWITTER ====----
	// https://dev.twitter.com/web/javascript/loading

	window.twttr = (function (d, s, id) {
		var js,
			fjs = d.getElementsByTagName(s)[0],
			t = window.twttr || {};
		if (d.getElementById(id)) return t;
		js = d.createElement(s);
		js.id = id;
		js.src = "https://platform.twitter.com/widgets.js";
		fjs.parentNode.insertBefore(js, fjs);

		t._e = [];
		t.ready = function (f) {
			t._e.push(f);
		};

		return t;
	}(document, "script", "twitter-wjs"));

});