// 22. Найти расстояние между точками в пространстве 2D/3D

// Status: решено



// 22.1 расстояние между точками в 2D

// int x1 = 2; // координаты первой точки на плоскости 
// int y1 = 2;

// int x2 = 3;  // координаты второй точки на плоскости
// int y2 = 3;

// double Distance2D(int x1, int y1, int x2, int y2)
// {
//     double katet1 = x2 - x1;
//     double katet2 = y2 - y1;
//     double dist = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
//     return dist;
// }

// System.Console.WriteLine(Distance2D(x1, y1, x2, y2));






// 22.2 расстояние между точками в 3D

int x1 = 2; // координаты первой точки в трехмерном пространстве
int y1 = 2;
int z1 = 2;

int x2 = 6;  // координаты второй точки в трехмерном пространстве
int y2 = 6;
int z2 = 6;

double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dis1 = x2 - x1;
    double dis2 = y2 - y1;
    double dis3 = z2 - z1;
    double dist = Math.Sqrt(dis1 * dis1 + dis2 * dis2 + dis3 * dis3);
    return dist;
}

System.Console.WriteLine(Distance3D(x1, y1, z1, x2, y2, z2));

