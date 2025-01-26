using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedisyncAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medications",
                columns: new[] { "Id", "Name", "SideEffects", "Use" },
                values: new object[,]
                {
                    { 1, "Aspirin", "Nausea, bleeding risk", "Reduces risk of blood clots, preventing heart attacks and strokes." },
                    { 2, "Lisinopril", "Cough, hyperkalemia", "Lowers blood pressure and protects the kidneys." },
                    { 3, "Metoprolol", "Fatigue, dizziness", "Lowers heart rate and blood pressure." },
                    { 4, "Amlodipine", "Swelling, headache", "Calcium channel blocker that helps lower blood pressure." },
                    { 5, "Metformin", "Gastrointestinal upset, lactic acidosis (rare)", "Reduces glucose production by the liver and increases insulin sensitivity." },
                    { 6, "Sulfonylureas (e.g., Glipizide)", "Hypoglycemia, weight gain", "Stimulates insulin production from the pancreas." },
                    { 7, "Insulin", "Hypoglycemia, weight gain", "Provides insulin to reduce blood glucose." },
                    { 8, "SGLT2 Inhibitors (e.g., Empagliflozin)", "Dehydration, urinary tract infections", "Reduces glucose reabsorption by the kidneys." },
                    { 9, "Atorvastatin", "Muscle pain, liver enzyme abnormalities", "Lowers LDL cholesterol and reduces cardiovascular disease risk." },
                    { 10, "Ezetimibe", "Diarrhea, fatigue", "Reduces cholesterol absorption from the gut." },
                    { 11, "Niacin", "Flushing, liver toxicity", "Increases HDL (good cholesterol) and lowers LDL and triglycerides." },
                    { 12, "Fibrate (e.g., Fenofibrate)", "Muscle toxicity, liver enzyme elevation", "Lowers triglycerides and raises HDL cholesterol." },
                    { 13, "Albuterol", "Tremors, increased heart rate", "Short-acting bronchodilator that opens airways during an attack." },
                    { 14, "Fluticasone", "Oral thrush, hoarseness", "Inhaled corticosteroid that reduces airway inflammation." },
                    { 15, "Prednisone", "Weight gain, osteoporosis with long-term use", "Oral corticosteroid for acute exacerbations of asthma." },
                    { 16, "Lisinopril", "Cough, hyperkalemia", "Protects kidneys, reduces proteinuria, and lowers blood pressure." },
                    { 17, "Iron Supplements", "Constipation, dark stools", "Replenishes iron levels for red blood cell production." },
                    { 18, "Alendronate", "Esophageal irritation, jaw osteonecrosis", "Strengthens bones and prevents fractures in osteoporosis." },
                    { 19, "Vitamin D", "Hypercalcemia, kidney stones", "Enhances calcium absorption and bone health." },
                    { 20, "Methotrexate", "Bone marrow suppression, liver toxicity", "Immunosuppressant for treating autoimmune conditions like rheumatoid arthritis." },
                    { 21, "Tramadol", "Drowsiness, dependency risk", "Opioid-like pain reliever for moderate to severe pain." },
                    { 22, "Gabapentin", "Dizziness, fatigue", "Anticonvulsant used to treat nerve pain." },
                    { 23, "Tiotropium", "Dry mouth, throat irritation", "Long-acting anticholinergic bronchodilator for COPD." },
                    { 24, "Formoterol", "Tremors, palpitations", "Long-acting beta-agonist bronchodilator." },
                    { 25, "Botulinum Toxin (Botox)", "Injection site pain, muscle weakness", "Prevents chronic migraines by blocking pain signals." },
                    { 26, "Amitriptyline", "Dry mouth, drowsiness", "Tricyclic antidepressant used for migraine prevention." },
                    { 27, "Proton Pump Inhibitors (e.g., Omeprazole)", "Bloating, constipation", "Reduces stomach acid production to treat GERD." },
                    { 28, "Antacids (e.g., Calcium Carbonate)", "Constipation, alkalosis", "Neutralizes stomach acid to relieve heartburn." },
                    { 29, "H2 Receptor Antagonists (e.g., Ranitidine)", "Headache, diarrhea", "Reduces stomach acid production to alleviate heartburn." },
                    { 30, "Beta-blockers (e.g., Carvedilol)", "Fatigue, bradycardia", "Reduces heart rate and workload, improving heart function." },
                    { 31, "Digoxin", "Nausea, arrhythmias", "Increases heart contractility and improves symptoms of heart failure." },
                    { 32, "Furosemide", "Electrolyte imbalance, dehydration", "Loop diuretic that removes excess fluid." },
                    { 33, "Spironolactone", "Hyperkalemia, gynecomastia", "Diuretic that reduces fluid retention and prevents potassium loss." },
                    { 34, "Valproic Acid", "Weight gain, liver toxicity", "Anticonvulsant used to control seizures." },
                    { 35, "Lamotrigine", "Rash, dizziness", "Anticonvulsant used for seizure control." },
                    { 36, "Levodopa", "Dyskinesia, nausea", "Converts to dopamine in the brain to alleviate symptoms of Parkinson's." },
                    { 37, "Carbidopa", "Dizziness, nausea", "Inhibits the breakdown of Levodopa, enhancing its effect." },
                    { 38, "Pramipexole", "Hallucinations, sleepiness", "Dopamine agonist for managing Parkinson's disease." },
                    { 39, "Albuterol", "Tremors, increased heart rate", "Short-acting bronchodilator for acute asthma relief." },
                    { 40, "Fluticasone", "Oral thrush, hoarseness", "Inhaled corticosteroid for long-term asthma control." },
                    { 41, "Ipratropium", "Dry mouth, throat irritation", "Long-acting bronchodilator for asthma prevention." },
                    { 42, "Prednisone", "Weight gain, osteoporosis", "Oral corticosteroid for severe asthma attacks." },
                    { 43, "Metoprolol", "Fatigue, dizziness", "Lowers heart rate and blood pressure." },
                    { 44, "Amlodipine", "Swelling, headache", "Calcium channel blocker that helps lower blood pressure." },
                    { 45, "Sulfonylureas (e.g., Glipizide)", "Hypoglycemia, weight gain", "Stimulates insulin production from the pancreas." },
                    { 46, "Niacin", "Flushing, liver toxicity", "Increases HDL (good cholesterol) and lowers LDL and triglycerides." },
                    { 47, "Fibrate (e.g., Fenofibrate)", "Muscle toxicity, liver enzyme elevation", "Lowers triglycerides and raises HDL cholesterol." }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$LL0raB/vJRtJjXeo6VEO3uiSYYfSYM3RQdMiJDSDeNiAI5XhqEvkS");

            migrationBuilder.InsertData(
                table: "Interactions",
                columns: new[] { "Id", "Cons", "InteractionType", "Medication1Id", "Medication2Id", "Pros", "Reasoning", "Severity" },
                values: new object[,]
                {
                    { 1, "Potential bleeding risk.", "Good", 1, 2, "Improved cardiovascular protection.", "Aspirin helps with blood thinning, and Lisinopril reduces blood pressure, protecting against heart attack.", "Moderate" },
                    { 2, "Monitor blood pressure and heart rate closely.", "Good", 1, 3, "Enhanced efficacy in preventing heart attack.", "Aspirin and Metoprolol work synergistically to reduce heart attack risk by thinning blood and reducing pressure.", "Mild" },
                    { 3, "High risk of hypoglycemia.", "Caution", 5, 6, "Effective blood sugar control.", "Both lower blood sugar, but can increase hypoglycemia risk when used together.", "Moderate" },
                    { 4, "Monitor liver function due to potential side effects.", "Good", 9, 10, "Improved cholesterol management.", "Atorvastatin inhibits cholesterol production, and Ezetimibe blocks its absorption.", "Mild" },
                    { 5, "Increased risk of side effects like dehydration and liver issues.", "Caution", 9, 8, "Effective in reducing cardiovascular risks.", "Combining SGLT2 inhibitors with Atorvastatin may increase dehydration and liver stress.", "Moderate" },
                    { 6, "Monitor for overuse of Albuterol.", "Good", 13, 14, "Effective asthma management.", "Albuterol provides immediate relief, and Fluticasone helps with long-term control of inflammation.", "Mild" },
                    { 7, "Monitor kidney function closely.", "Caution", 16, 17, "Helps manage chronic kidney disease symptoms.", "Diuretics can worsen kidney function, especially when used long-term with Lisinopril.", "Moderate" },
                    { 8, "Ensure proper calcium levels to avoid hypercalcemia.", "Good", 18, 19, "Improved bone density.", "Vitamin D aids in calcium absorption, enhancing the effectiveness of Alendronate.", "Mild" },
                    { 9, "Monitor liver function due to Methotrexate.", "Good", 20, 19, "Reduces inflammation while maintaining bone health.", "Vitamin D and Methotrexate are often used together in autoimmune disease treatment to ensure proper bone health.", "Moderate" },
                    { 10, "Monitor for potential sedation or dependency.", "Good", 21, 22, "Improved pain management in neuropathic conditions.", "Gabapentin enhances the pain-relieving effect of Tramadol, especially in neuropathic pain.", "Mild" },
                    { 11, "Monitor for overuse of bronchodilators.", "Good", 23, 24, "Better long-term control of COPD symptoms.", "Combining Tiotropium and Formoterol helps maintain open airways, improving breathing in COPD patients.", "Mild" },
                    { 12, "Potential side effects of Amitriptyline (drowsiness, dry mouth).", "Good", 25, 26, "Effective reduction in migraine frequency.", "Botulinum toxin and Amitriptyline work synergistically to prevent and reduce the frequency of chronic migraines.", "Moderate" },
                    { 13, "Risk of alkalosis and bloating.", "Caution", 27, 28, "Effective combination for severe GERD.", "Proton Pump Inhibitors decrease acid production, while Antacids neutralize acid; excessive use can cause digestive issues.", "Moderate" },
                    { 14, "Monitor for long-term side effects of acid suppression.", "Good", 29, 27, "Enhanced acid control in severe GERD.", "Both H2 blockers and PPIs are effective in treating GERD, often used in combination for more severe cases.", "Mild" },
                    { 15, "Monitor for bradycardia and digoxin toxicity.", "Good", 30, 31, "Improved heart failure management.", "Beta-blockers lower the heart's demand for oxygen, and Digoxin improves contractility, both supporting heart failure patients.", "Moderate" },
                    { 16, "Monitor potassium levels closely.", "Good", 32, 33, "Effective fluid management in heart failure.", "Furosemide removes excess fluid, while Spironolactone prevents potassium loss, creating a balanced diuretic effect.", "Mild" },
                    { 17, "High risk of adverse reactions without dose adjustments.", "Caution", 34, 35, "Effective seizure control when managed properly.", "Combining Valproic Acid with Lamotrigine can increase the risk of Lamotrigine toxicity, requiring dose adjustments.", "Moderate" },
                    { 18, "Potential for nausea and dyskinesia.", "Good", 36, 37, "Improved Parkinson's symptom management.", "Carbidopa helps Levodopa reach the brain more effectively, enhancing its therapeutic effect in Parkinson's disease.", "Mild" },
                    { 19, "High risk of dopaminergic side effects.", "Caution", 36, 38, "Enhanced symptom control in Parkinson's.", "Combining Pramipexole and Levodopa can increase the risk of dopaminergic side effects like hallucinations or dyskinesia.", "Moderate" },
                    { 20, "Monitor for overuse of Albuterol.", "Good", 39, 40, "Effective asthma management.", "Albuterol provides quick relief, while Fluticasone helps with long-term inflammation control.", "Mild" },
                    { 21, "Monitor for dry mouth and irritation.", "Good", 39, 41, "Comprehensive asthma treatment.", "Albuterol provides immediate relief, while Ipratropium prevents future bronchospasms.", "Mild" },
                    { 22, "Risk of corticosteroid-related side effects.", "Good", 40, 42, "Improved control during severe asthma.", "Fluticasone and Prednisone both reduce inflammation, effective during asthma flare-ups.", "Moderate" },
                    { 23, "Risk of excessive blood pressure drop.", "Good", 43, 44, "Effective blood pressure control.", "Metoprolol and Amlodipine work synergistically to lower blood pressure and reduce cardiovascular risk.", "Mild" },
                    { 24, "Risk of glycemic imbalance.", "Caution", 45, 46, "Improved lipid and glucose control when monitored.", "Sulfonylureas and Niacin can increase the risk of hyperglycemia in diabetic patients.", "Moderate" },
                    { 25, "High risk of muscle and liver toxicity.", "Caution", 46, 47, "Improved lipid profile management.", "Combining Niacin and Fibrates increases the risk of muscle and liver toxicity.", "Moderate" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Interactions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Medications",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "PasswordHash",
                value: "$2a$11$N0HhZNL2F3wNrHpWyPbm/.3AJQ6cIRf3.5xqhPLL0k0eb6GPpGTOS");
        }
    }
}
