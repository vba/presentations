#####################################################
#
#             Source map and debugging
#
#####################################################

class Checker
	constructor: (@alert=yes, @message ="I found it") ->
	
	check: (@id) -> 
		debugger
		func = 
			if @alert and alert? 
				alert 
			else 
				console.log

		func (@message) if document?.getElementById(@id)

new Checker().check('rubbish')
new Checker().check('element1')
