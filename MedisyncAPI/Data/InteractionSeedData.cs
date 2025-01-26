using Microsoft.EntityFrameworkCore;
using MedisyncAPI.models;

namespace MedisyncAPI.Data.Seeds
{
     public static class InteractionSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Interaction>().HasData(
                new Interaction
                {
                    Id = 1,
                    Medication1Id = 1,
                    Medication2Id = 2,
                    InteractionType = "Good",
                    Reasoning = "Aspirin helps with blood thinning, and Lisinopril reduces blood pressure, protecting against heart attack.",
                    Pros = "Improved cardiovascular protection.",
                    Cons = "Potential bleeding risk.",
                    Severity = "Moderate"
                },
                new Interaction
                {
                    Id = 2,
                    Medication1Id = 1,
                    Medication2Id = 3,
                    InteractionType = "Good",
                    Reasoning = "Aspirin and Metoprolol work synergistically to reduce heart attack risk by thinning blood and reducing pressure.",
                    Pros = "Enhanced efficacy in preventing heart attack.",
                    Cons = "Monitor blood pressure and heart rate closely.",
                    Severity = "Mild"
                },
                 new Interaction
                {
                    Id = 3,
                    Medication1Id = 5,
                    Medication2Id = 6,
                    InteractionType = "Caution",
                    Reasoning = "Both lower blood sugar, but can increase hypoglycemia risk when used together.",
                    Pros = "Effective blood sugar control.",
                    Cons = "High risk of hypoglycemia.",
                    Severity = "Moderate"
                },
                new Interaction
                {
                    Id = 4,
                    Medication1Id = 9,
                    Medication2Id = 10,
                    InteractionType = "Good",
                    Reasoning = "Atorvastatin inhibits cholesterol production, and Ezetimibe blocks its absorption.",
                    Pros = "Improved cholesterol management.",
                    Cons = "Monitor liver function due to potential side effects.",
                    Severity = "Mild"
                },
                new Interaction
                {
                    Id = 5,
                    Medication1Id = 9,
                    Medication2Id = 8,
                    InteractionType = "Caution",
                    Reasoning = "Combining SGLT2 inhibitors with Atorvastatin may increase dehydration and liver stress.",
                    Pros = "Effective in reducing cardiovascular risks.",
                    Cons = "Increased risk of side effects like dehydration and liver issues.",
                    Severity = "Moderate"
                },
                 new Interaction
                {
                    Id = 6,
                    Medication1Id = 13,
                    Medication2Id = 14,
                    InteractionType = "Good",
                    Reasoning = "Albuterol provides immediate relief, and Fluticasone helps with long-term control of inflammation.",
                    Pros = "Effective asthma management.",
                    Cons = "Monitor for overuse of Albuterol.",
                    Severity = "Mild"
                },
                new Interaction
                {
                    Id = 7,
                    Medication1Id = 16,
                    Medication2Id = 17,
                    InteractionType = "Caution",
                    Reasoning = "Diuretics can worsen kidney function, especially when used long-term with Lisinopril.",
                    Pros = "Helps manage chronic kidney disease symptoms.",
                    Cons = "Monitor kidney function closely.",
                    Severity = "Moderate"
                },
                new Interaction
                {
                    Id = 8,
                    Medication1Id = 18,
                    Medication2Id = 19,
                    InteractionType = "Good",
                    Reasoning = "Vitamin D aids in calcium absorption, enhancing the effectiveness of Alendronate.",
                    Pros = "Improved bone density.",
                    Cons = "Ensure proper calcium levels to avoid hypercalcemia.",
                    Severity = "Mild"
                },
                new Interaction
                {
                    Id = 9,
                    Medication1Id = 20,
                    Medication2Id = 19,
                    InteractionType = "Good",
                    Reasoning = "Vitamin D and Methotrexate are often used together in autoimmune disease treatment to ensure proper bone health.",
                    Pros = "Reduces inflammation while maintaining bone health.",
                    Cons = "Monitor liver function due to Methotrexate.",
                    Severity = "Moderate"
                },
                new Interaction
                {
                    Id = 10,
                    Medication1Id = 21,
                    Medication2Id = 22,
                    InteractionType = "Good",
                    Reasoning = "Gabapentin enhances the pain-relieving effect of Tramadol, especially in neuropathic pain.",
                    Pros = "Improved pain management in neuropathic conditions.",
                    Cons = "Monitor for potential sedation or dependency.",
                    Severity = "Mild"
                },
                new Interaction
                {
                    Id = 11,
                    Medication1Id = 23,
                    Medication2Id = 24,
                    InteractionType = "Good",
                    Reasoning = "Combining Tiotropium and Formoterol helps maintain open airways, improving breathing in COPD patients.",
                    Pros = "Better long-term control of COPD symptoms.",
                    Cons = "Monitor for overuse of bronchodilators.",
                    Severity = "Mild"
                },
                new Interaction
                {
                    Id = 12,
                    Medication1Id = 25,
                    Medication2Id = 26,
                    InteractionType = "Good",
                    Reasoning = "Botulinum toxin and Amitriptyline work synergistically to prevent and reduce the frequency of chronic migraines.",
                    Pros = "Effective reduction in migraine frequency.",
                    Cons = "Potential side effects of Amitriptyline (drowsiness, dry mouth).",
                    Severity = "Moderate"
                },
                 new Interaction
                {
                    Id = 13,
                    Medication1Id = 27,
                    Medication2Id = 28,
                    InteractionType = "Caution",
                    Reasoning = "Proton Pump Inhibitors decrease acid production, while Antacids neutralize acid; excessive use can cause digestive issues.",
                    Pros = "Effective combination for severe GERD.",
                    Cons = "Risk of alkalosis and bloating.",
                    Severity = "Moderate"
                },
                new Interaction
                {
                    Id = 14,
                    Medication1Id = 29,
                    Medication2Id = 27,
                    InteractionType = "Good",
                    Reasoning = "Both H2 blockers and PPIs are effective in treating GERD, often used in combination for more severe cases.",
                    Pros = "Enhanced acid control in severe GERD.",
                    Cons = "Monitor for long-term side effects of acid suppression.",
                    Severity = "Mild"
                },
                 new Interaction
                {
                    Id = 15,
                    Medication1Id = 30,
                    Medication2Id = 31,
                    InteractionType = "Good",
                    Reasoning = "Beta-blockers lower the heart's demand for oxygen, and Digoxin improves contractility, both supporting heart failure patients.",
                    Pros = "Improved heart failure management.",
                    Cons = "Monitor for bradycardia and digoxin toxicity.",
                    Severity = "Moderate"
                },
                new Interaction
                {
                    Id = 16,
                    Medication1Id = 32,
                    Medication2Id = 33,
                    InteractionType = "Good",
                    Reasoning = "Furosemide removes excess fluid, while Spironolactone prevents potassium loss, creating a balanced diuretic effect.",
                    Pros = "Effective fluid management in heart failure.",
                    Cons = "Monitor potassium levels closely.",
                    Severity = "Mild"
                },
                new Interaction
                {
                    Id = 17,
                    Medication1Id = 34,
                    Medication2Id = 35,
                    InteractionType = "Caution",
                    Reasoning = "Combining Valproic Acid with Lamotrigine can increase the risk of Lamotrigine toxicity, requiring dose adjustments.",
                    Pros = "Effective seizure control when managed properly.",
                    Cons = "High risk of adverse reactions without dose adjustments.",
                    Severity = "Moderate"
                },
                new Interaction
                {
                    Id = 18,
                    Medication1Id = 36,
                    Medication2Id = 37,
                    InteractionType = "Good",
                    Reasoning = "Carbidopa helps Levodopa reach the brain more effectively, enhancing its therapeutic effect in Parkinson's disease.",
                    Pros = "Improved Parkinson's symptom management.",
                    Cons = "Potential for nausea and dyskinesia.",
                    Severity = "Mild"
                },
                new Interaction
                {
                    Id = 19,
                    Medication1Id = 36,
                    Medication2Id = 38,
                    InteractionType = "Caution",
                    Reasoning = "Combining Pramipexole and Levodopa can increase the risk of dopaminergic side effects like hallucinations or dyskinesia.",
                    Pros = "Enhanced symptom control in Parkinson's.",
                    Cons = "High risk of dopaminergic side effects.",
                    Severity = "Moderate"
                },
                 new Interaction
                {
                    Id = 20,
                    Medication1Id = 39,
                    Medication2Id = 40,
                    InteractionType = "Good",
                    Reasoning = "Albuterol provides quick relief, while Fluticasone helps with long-term inflammation control.",
                    Pros = "Effective asthma management.",
                    Cons = "Monitor for overuse of Albuterol.",
                    Severity = "Mild"
                },
                new Interaction
                {
                    Id = 21,
                    Medication1Id = 39,
                    Medication2Id = 41,
                    InteractionType = "Good",
                    Reasoning = "Albuterol provides immediate relief, while Ipratropium prevents future bronchospasms.",
                    Pros = "Comprehensive asthma treatment.",
                    Cons = "Monitor for dry mouth and irritation.",
                    Severity = "Mild"
                },
                new Interaction
                {
                    Id = 22,
                    Medication1Id = 40,
                    Medication2Id = 42,
                    InteractionType = "Good",
                    Reasoning = "Fluticasone and Prednisone both reduce inflammation, effective during asthma flare-ups.",
                    Pros = "Improved control during severe asthma.",
                    Cons = "Risk of corticosteroid-related side effects.",
                    Severity = "Moderate"
                },
                 new Interaction
                {
                    Id = 23,
                    Medication1Id = 43,
                    Medication2Id = 44,
                    InteractionType = "Good",
                    Reasoning = "Metoprolol and Amlodipine work synergistically to lower blood pressure and reduce cardiovascular risk.",
                    Pros = "Effective blood pressure control.",
                    Cons = "Risk of excessive blood pressure drop.",
                    Severity = "Mild"
                },
                new Interaction
                {
                    Id = 24,
                    Medication1Id = 45,
                    Medication2Id = 46,
                    InteractionType = "Caution",
                    Reasoning = "Sulfonylureas and Niacin can increase the risk of hyperglycemia in diabetic patients.",
                    Pros = "Improved lipid and glucose control when monitored.",
                    Cons = "Risk of glycemic imbalance.",
                    Severity = "Moderate"
                },
                new Interaction
                {
                    Id = 25,
                    Medication1Id = 46,
                    Medication2Id = 47,
                    InteractionType = "Caution",
                    Reasoning = "Combining Niacin and Fibrates increases the risk of muscle and liver toxicity.",
                    Pros = "Improved lipid profile management.",
                    Cons = "High risk of muscle and liver toxicity.",
                    Severity = "Moderate"
                }
                // Add more interactions here based on the document
            );
        }
    }
}
