#include <QCoreApplication>
#include <QDebug>

int main(int argc, char *argv[])
{
    QCoreApplication a(argc, argv);
    QString str = "Hello, world";
    qDebug() << str;

    return a.exec();
}
