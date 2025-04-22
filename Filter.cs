namespace Predicate {

    delegate bool Del <T> (T item);
    class Filter {

        public static List <T> Filtring <T> (List <T> list , Del <T> D ) {

                List<T> Result = new List <T> ();

                foreach ( T item in list ) {
                    if ( D ( item ) ) {
                        Result.Add ( item );
                    }
                }
                return Result;

        }

        
    }
}