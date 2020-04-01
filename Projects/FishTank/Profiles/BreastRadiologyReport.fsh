Alias: LOINC = http://loinc.org 

Profile: BreastRadiologyReport
Parent: DiagnosticReport
Id: breastRadiologyReport
Title: "Breast Radiology Report"
Mixins: HeaderFragment
Description: """
	Breast Radiology Diagnostic Report.

    This profile is one of the components of a Breast Radiology Document.
    Each Breast Radiology Document bundle will contain exactly one
    Breast Radiology Document instance that is referenced in the
    document's 'Report' section.
    
    This instance will contain the top level results of the exam,
    including the narrative result.
    
	This resource is a profile of the FHIR DiagnosticReport
    base resource.	
	"""

  * conclusionCode from BiRadsAssessmentCategoryVS (required)
  * code = LOINC#10193-1
  * specimen 0..0
  * result 0..0
  