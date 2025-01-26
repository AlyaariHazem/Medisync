using Microsoft.EntityFrameworkCore;
using MedisyncAPI.models;

namespace MedisyncAPI.Data.Seeds
{
    public static class MedicationSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Medication>().HasData(
                new Medication
                {
                    Id = 1,
                    Name = "Aspirin",
                    Use = "Reduces risk of blood clots, preventing heart attacks and strokes.",
                    SideEffects = "Nausea, bleeding risk"
                },
                new Medication
                {
                    Id = 2,
                    Name = "Lisinopril",
                    Use = "Lowers blood pressure and protects the kidneys.",
                    SideEffects = "Cough, hyperkalemia"
                },
                new Medication
                {
                    Id = 3,
                    Name = "Metoprolol",
                    Use = "Lowers heart rate and blood pressure.",
                    SideEffects = "Fatigue, dizziness"
                },
                new Medication
                {
                    Id = 4,
                    Name = "Amlodipine",
                    Use = "Calcium channel blocker that helps lower blood pressure.",
                    SideEffects = "Swelling, headache"
                },
                new Medication
                {
                    Id = 5,
                    Name = "Metformin",
                    Use = "Reduces glucose production by the liver and increases insulin sensitivity.",
                    SideEffects = "Gastrointestinal upset, lactic acidosis (rare)"
                },
                new Medication
                {
                    Id = 6,
                    Name = "Sulfonylureas (e.g., Glipizide)",
                    Use = "Stimulates insulin production from the pancreas.",
                    SideEffects = "Hypoglycemia, weight gain"
                },
                new Medication
                {
                    Id = 7,
                    Name = "Insulin",
                    Use = "Provides insulin to reduce blood glucose.",
                    SideEffects = "Hypoglycemia, weight gain"
                },
                new Medication
                {
                    Id = 8,
                    Name = "SGLT2 Inhibitors (e.g., Empagliflozin)",
                    Use = "Reduces glucose reabsorption by the kidneys.",
                    SideEffects = "Dehydration, urinary tract infections"
                },
                new Medication
                {
                    Id = 9,
                    Name = "Atorvastatin",
                    Use = "Lowers LDL cholesterol and reduces cardiovascular disease risk.",
                    SideEffects = "Muscle pain, liver enzyme abnormalities"
                },
                new Medication
                {
                    Id = 10,
                    Name = "Ezetimibe",
                    Use = "Reduces cholesterol absorption from the gut.",
                    SideEffects = "Diarrhea, fatigue"
                },
                 new Medication
                {
                    Id = 11,
                    Name = "Niacin",
                    Use = "Increases HDL (good cholesterol) and lowers LDL and triglycerides.",
                    SideEffects = "Flushing, liver toxicity"
                },
                new Medication
                {
                    Id = 12,
                    Name = "Fibrate (e.g., Fenofibrate)",
                    Use = "Lowers triglycerides and raises HDL cholesterol.",
                    SideEffects = "Muscle toxicity, liver enzyme elevation"
                },
                new Medication
                {
                    Id = 13,
                    Name = "Albuterol",
                    Use = "Short-acting bronchodilator that opens airways during an attack.",
                    SideEffects = "Tremors, increased heart rate"
                },
                new Medication
                {
                    Id = 14,
                    Name = "Fluticasone",
                    Use = "Inhaled corticosteroid that reduces airway inflammation.",
                    SideEffects = "Oral thrush, hoarseness"
                },
                new Medication
                {
                    Id = 15,
                    Name = "Prednisone",
                    Use = "Oral corticosteroid for acute exacerbations of asthma.",
                    SideEffects = "Weight gain, osteoporosis with long-term use"
                },
                new Medication
                {
                    Id = 16,
                    Name = "Lisinopril",
                    Use = "Protects kidneys, reduces proteinuria, and lowers blood pressure.",
                    SideEffects = "Cough, hyperkalemia"
                },
                new Medication
                {
                    Id = 17,
                    Name = "Iron Supplements",
                    Use = "Replenishes iron levels for red blood cell production.",
                    SideEffects = "Constipation, dark stools"
                },
                new Medication
                {
                    Id = 18,
                    Name = "Alendronate",
                    Use = "Strengthens bones and prevents fractures in osteoporosis.",
                    SideEffects = "Esophageal irritation, jaw osteonecrosis"
                },
                new Medication
                {
                    Id = 19,
                    Name = "Vitamin D",
                    Use = "Enhances calcium absorption and bone health.",
                    SideEffects = "Hypercalcemia, kidney stones"
                },
                new Medication
                {
                    Id = 20,
                    Name = "Methotrexate",
                    Use = "Immunosuppressant for treating autoimmune conditions like rheumatoid arthritis.",
                    SideEffects = "Bone marrow suppression, liver toxicity"
                },
                 new Medication
                {
                    Id = 21,
                    Name = "Tramadol",
                    Use = "Opioid-like pain reliever for moderate to severe pain.",
                    SideEffects = "Drowsiness, dependency risk"
                },
                new Medication
                {
                    Id = 22,
                    Name = "Gabapentin",
                    Use = "Anticonvulsant used to treat nerve pain.",
                    SideEffects = "Dizziness, fatigue"
                },
                new Medication
                {
                    Id = 23,
                    Name = "Tiotropium",
                    Use = "Long-acting anticholinergic bronchodilator for COPD.",
                    SideEffects = "Dry mouth, throat irritation"
                },
                new Medication
                {
                    Id = 24,
                    Name = "Formoterol",
                    Use = "Long-acting beta-agonist bronchodilator.",
                    SideEffects = "Tremors, palpitations"
                },
                new Medication
                {
                    Id = 25,
                    Name = "Botulinum Toxin (Botox)",
                    Use = "Prevents chronic migraines by blocking pain signals.",
                    SideEffects = "Injection site pain, muscle weakness"
                },
                new Medication
                {
                    Id = 26,
                    Name = "Amitriptyline",
                    Use = "Tricyclic antidepressant used for migraine prevention.",
                    SideEffects = "Dry mouth, drowsiness"
                },
                 new Medication
                {
                    Id = 27,
                    Name = "Proton Pump Inhibitors (e.g., Omeprazole)",
                    Use = "Reduces stomach acid production to treat GERD.",
                    SideEffects = "Bloating, constipation"
                },
                new Medication
                {
                    Id = 28,
                    Name = "Antacids (e.g., Calcium Carbonate)",
                    Use = "Neutralizes stomach acid to relieve heartburn.",
                    SideEffects = "Constipation, alkalosis"
                },
                new Medication
                {
                    Id = 29,
                    Name = "H2 Receptor Antagonists (e.g., Ranitidine)",
                    Use = "Reduces stomach acid production to alleviate heartburn.",
                    SideEffects = "Headache, diarrhea"
                },
                 new Medication
                {
                    Id = 30,
                    Name = "Beta-blockers (e.g., Carvedilol)",
                    Use = "Reduces heart rate and workload, improving heart function.",
                    SideEffects = "Fatigue, bradycardia"
                },
                new Medication
                {
                    Id = 31,
                    Name = "Digoxin",
                    Use = "Increases heart contractility and improves symptoms of heart failure.",
                    SideEffects = "Nausea, arrhythmias"
                },
                new Medication
                {
                    Id = 32,
                    Name = "Furosemide",
                    Use = "Loop diuretic that removes excess fluid.",
                    SideEffects = "Electrolyte imbalance, dehydration"
                },
                new Medication
                {
                    Id = 33,
                    Name = "Spironolactone",
                    Use = "Diuretic that reduces fluid retention and prevents potassium loss.",
                    SideEffects = "Hyperkalemia, gynecomastia"
                },
                new Medication
                {
                    Id = 34,
                    Name = "Valproic Acid",
                    Use = "Anticonvulsant used to control seizures.",
                    SideEffects = "Weight gain, liver toxicity"
                },
                new Medication
                {
                    Id = 35,
                    Name = "Lamotrigine",
                    Use = "Anticonvulsant used for seizure control.",
                    SideEffects = "Rash, dizziness"
                },
                new Medication
                {
                    Id = 36,
                    Name = "Levodopa",
                    Use = "Converts to dopamine in the brain to alleviate symptoms of Parkinson's.",
                    SideEffects = "Dyskinesia, nausea"
                },
                new Medication
                {
                    Id = 37,
                    Name = "Carbidopa",
                    Use = "Inhibits the breakdown of Levodopa, enhancing its effect.",
                    SideEffects = "Dizziness, nausea"
                },
                new Medication
                {
                    Id = 38,
                    Name = "Pramipexole",
                    Use = "Dopamine agonist for managing Parkinson's disease.",
                    SideEffects = "Hallucinations, sleepiness"
                },
                 new Medication
                {
                    Id = 39,
                    Name = "Albuterol",
                    Use = "Short-acting bronchodilator for acute asthma relief.",
                    SideEffects = "Tremors, increased heart rate"
                },
                new Medication
                {
                    Id = 40,
                    Name = "Fluticasone",
                    Use = "Inhaled corticosteroid for long-term asthma control.",
                    SideEffects = "Oral thrush, hoarseness"
                },
                new Medication
                {
                    Id = 41,
                    Name = "Ipratropium",
                    Use = "Long-acting bronchodilator for asthma prevention.",
                    SideEffects = "Dry mouth, throat irritation"
                },
                new Medication
                {
                    Id = 42,
                    Name = "Prednisone",
                    Use = "Oral corticosteroid for severe asthma attacks.",
                    SideEffects = "Weight gain, osteoporosis"
                },
                 new Medication
                {
                    Id = 43,
                    Name = "Metoprolol",
                    Use = "Lowers heart rate and blood pressure.",
                    SideEffects = "Fatigue, dizziness"
                },
                new Medication
                {
                    Id = 44,
                    Name = "Amlodipine",
                    Use = "Calcium channel blocker that helps lower blood pressure.",
                    SideEffects = "Swelling, headache"
                },
                new Medication
                {
                    Id = 45,
                    Name = "Sulfonylureas (e.g., Glipizide)",
                    Use = "Stimulates insulin production from the pancreas.",
                    SideEffects = "Hypoglycemia, weight gain"
                },
                new Medication
                {
                    Id = 46,
                    Name = "Niacin",
                    Use = "Increases HDL (good cholesterol) and lowers LDL and triglycerides.",
                    SideEffects = "Flushing, liver toxicity"
                },
                new Medication
                {
                    Id = 47,
                    Name = "Fibrate (e.g., Fenofibrate)",
                    Use = "Lowers triglycerides and raises HDL cholesterol.",
                    SideEffects = "Muscle toxicity, liver enzyme elevation"
                }
                // Add more medications here based on the document
            );
        }
    }

    
}
