namespace Transformer {

    delegate T Del <T, T2> (T2 item);
    class ListTransform {

        public static List <T> Transforming <T, T2> ( List<T2> list, Del <T ,T2> D) {
            List <T> result = new List <T> ();

            foreach (T2 item in list) {
                result.Add (D(item));
            }
            return result;
        }
    }
}