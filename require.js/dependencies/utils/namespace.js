
define(function() {
	return {
		register: function(name, scope) {
			var
				a = name,
				o = scope == null ? window : scope,
				j,
				d;
			
			d = name.split(".");
			
			for (j = 0; j < d.length; j = j + 1) {
				o[d[j]] = o[d[j]] || {};
				o = o[d[j]];
			}
			return o;
		}
	}
});