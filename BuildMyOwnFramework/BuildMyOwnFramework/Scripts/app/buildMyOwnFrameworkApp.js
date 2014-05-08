(function () {
    'use strict';

    window.onerror = function (msg) {
        if (window.alerts) {
            window.alerts.error("There was a problem with your last action.  Please reload the page, then try again.");
        } else {
            alert("Something serious went wrong.  Please close out of Build My Own Framework App, then try again.");
        }
    };

    var id = 'buildMyOwnFrameworkApp';

    var buildMyOwnFrameworkApp = angular.module(id, []);

	buildMyOwnFrameworkApp.run([
		function() {
			//Startup code goes here!
		}
	]);
})();