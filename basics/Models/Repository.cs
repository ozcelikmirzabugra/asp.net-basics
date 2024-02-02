namespace basics.Models {
    public class Repository {
        private static readonly List<Course> _courses = new();


        static Repository() {
            _courses = new List<Course>(){
            new Course() {
                Id = 1,
                Title = "aspnet course",
                Description = "a normal course",
                Image="1.jpg",
                Tags= new string[] {"aspnet", "web gelistirme"},
                isActive = true,
                isHome = true
            },
                        new Course() {
                Id = 2,
                Title = "php course",
                Description = "a normal course",
                Image="2.jpg",
                Tags= new string[] {"aspnet", "web gelistirme"},
                isActive = true,
                isHome = true
            },
                        new Course() {
                Id = 3,
                Title = "django course",
                Description = "a normal course",
                Image="3.jpg",
                Tags= new string[] {"aspnet", "web gelistirme"},
                isActive = true,
                isHome = true
            },
                        new Course() {
                Id = 4,
                Title = "javascript",
                Description = "a normal course",
                Image="1.jpg",
                Tags= new string[] {"aspnet", "web gelistirme"},
                isActive = false,
                isHome = true
            },
        };
            
    }


        public static List<Course> Courses {
            get {
                return _courses;
            }
        }

        public static Course? GetById(int? id) {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}