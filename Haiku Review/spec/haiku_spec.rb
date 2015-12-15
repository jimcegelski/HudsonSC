require 'rspec'
require_relative '../lib/haiku_review'

describe HaikuReview do

  it 'should return yes if it has three lines' do
    expect(subject.review('one/two/three')).to eq('yes')
  end

  it 'should return no if it has less than three lines' do
    expect(subject.review('one/two')).to eq('no')
  end

  it 'should return no if it has greater than three lines' do
    expect(subject.review('one/two/three/four')).to eq('no')
  end

  it 'should return no if the haiku contains more than 200 characters' do
    expect(subject.review(';alskjf;lsakjf;lksadjf;salkdjfsa;kdjfsa;kdjf;sakdhf;sakdhf;sakhfsak/jdhfsakjdhflkjsahflsakjdhflsakjhflsahflksajdhflsakjhflkjsahfl/ksajhflksajhflkjsaflkajshdlfkjashdlfkjashdflkjsahflkjsahflksajdhflkjsatts')).to eq('no')
  end

  it 'should return no if there is an uppercase letter' do
    expect(subject.review('one/two/Three')).to eq('no')
  end

  it 'should return yes if there is a space' do
    expect(subject.review('o ne/two/three')).to eq('yes')
  end

  it 'should be capable of counting syllables for a line' do
    expect(subject.count_syllables('two two')).to eq(2)
  end

end