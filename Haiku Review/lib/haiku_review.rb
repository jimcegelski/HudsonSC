class HaikuReview

  def review(potential_haiku)
    return 'no' if potential_haiku.delete('/').size > 200
    number_of_lines = potential_haiku.split('/').size
    return 'no' if number_of_lines != 3
    return 'no' if /[ a-z,\/]*/.match(potential_haiku).to_s != potential_haiku

    return 'yes'
  end

  def count_syllables(haiku_line)
    words = haiku_line.split(' ')
    words.each do


    end
  end

end