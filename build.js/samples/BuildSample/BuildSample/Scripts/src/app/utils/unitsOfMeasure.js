(function () {
	'use strict';

	define(['underscore'], function (_) {

		var Celsius = function (initialValue) {
			if (!_.isNumber(initialValue)) {
				throw 'Argument error, initialValue must be a number';
			}
			this.value = initialValue;
		};

		Celsius.prototype = (function () {
			return {
				toFahrenheit: function () {
					return this.value * 1.8 + 32;
				},
				toKelvin: function () {
					return this.value + 273.15;
				},
				toReaumur: function () {
					return this.value * 0.8;
				},
				toRankine: function () {
					return this.value * 1.8 + 32 + 459.67;
				}
			};

		}());

		return {
			temperature: {
				Celsius: Celsius
			}
		};
	});

}());