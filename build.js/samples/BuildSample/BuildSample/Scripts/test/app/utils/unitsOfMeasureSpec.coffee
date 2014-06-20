


define ['app/utils/unitsOfMeasure', 'chai'], (uom, chai) ->
	
	expect = chai.expect

	describe 'When temperature units of mesaure are used', ->
	
		it "it should find temperature class in the exposed tree", () ->
			expect(uom.temperature.Celsius != null).to.equal(true)


		it "it should fail with invalid constructor arguments", () ->
			expect(()->new uom.temperature.Celsius(null)).to.throw "Argument error, initialValue must be a number"


		it "it should convert to fahrenheit as expected", () ->
			sut1 = new uom.temperature.Celsius(0)
			sut2 = new uom.temperature.Celsius(21)
			
			expect(sut1.toFahrenheit()).to.equal 32
			expect(sut2.toFahrenheit())
				.to.be.above(69)
				.and.to.be.below(70)

		it "it should convert to kelvin as expected", () ->
			sut1 = new uom.temperature.Celsius(0)
			sut2 = new uom.temperature.Celsius(21)
			
			expect(sut1.toKelvin()).to.equal 273.15
			expect(sut2.toKelvin()).to.equal(273.15 + 21)

		it 'it should convert to reaumur as expected', () ->
			sut = new uom.temperature.Celsius(21)
			
			expect(sut.toReaumur())
				.to.be.above(16.7)
				.and.to.be.below(17)

		it 'it should convert to rankine as expected', () ->
			sut = new uom.temperature.Celsius(22)

			expect(sut.toRankine())
				.to.be.above(531)
				.and.to.be.below(531.3)

