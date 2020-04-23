// CategoryFragment
// This fragment slices Observation.category and 
// fixes the observation.code value to 'imaging'.

#macro CategoryFragment()
  * category ^slicing.discriminator.type = #pattern
  * category ^slicing.discriminator.path = "$this"
  * category ^slicing.rules = #open
  * category ^slicing.ordered = false
  * category ^slicing.description = "Observation Category = imaging"
  * category contains categoryImaging 1..1
  * entry[categoryImaging] = "http://terminology.hl7.org/CodeSystem/observation-category#imaging"
#end