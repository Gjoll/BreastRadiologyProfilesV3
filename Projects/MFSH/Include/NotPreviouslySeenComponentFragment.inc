#include "Common.inc"
#use "HeaderFragment.inc"
#use "NodeGraph.inc"
#use "IntroDoc.inc"
#use "IGBuilder.inc"

// Adds NotPreviously Seen Component slice.
#macro NotPreviouslySeenComponentFragment()

  #apply ObservationAddComponent("notPreviouslySeen", "0..*", "Not Previously Seen", "Not Previously Seen",
  #	"""
  # This slice contains the optional components that define prevous encounters in which this abnormality was not seen.
  # The value of this component is a codeable concept chosen from the NotPreviouslySeenVS valueset.
  #	""",
  #   "ObservationComponentSliceCodes#notPreviouslySeen")

  #apply ObservationSetComponentConcept("notPreviouslySeen", "1..1", "NotPreviouslySeenVS")
#end


/*
   Value set that defines Not Previously Seen codes.
 */
ValueSet:  NotPreviouslySeenVS
Title: "NotPreviouslySeen ValueSet"
Description:  "NotPreviouslySeen Value Set"
  * codes from system NotPreviouslySeenCS


/*
   Code system that defines Not Previously Seen codes.
 */
CodeSystem:  NotPreviouslySeenCS
Title: "NotPreviouslySeen CodeSystem"
Description:  "NotPreviouslySeen CodeSystem"
  * #ClinicalExam "Clinical exam"

  // .SnomedDescription Procedure | 420131003 | Fluoroscopic mammary ductography (Procedure)
  * #Ductogram "Ductogram"

  * #Mammogram "Mammogram"

  // .SnomedDescription Procedure | 241615005 | Magnetic resonance imaging of breast (Procedure)
  * #MRI "MRI"

  * #OutsideExam "Outside exam"

  * #Scintimammography "Scintimammography"

  // .SnomedDescription Procedure | 47079000 | Ultrasonography of breast (Procedure)
  * #Ultrasound "Ultrasound"


